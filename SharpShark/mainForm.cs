using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PacketDotNet;
using SharpPcap;

namespace SharpShark
{
    public partial class mainForm : Form
    {
        /// <summary>
        /// 主窗体构造函数
        /// </summary>
        public mainForm()
        {
            InitializeComponent();
        }

        LivePcapDevice device;

        const int maxCount=200000;  //20万

        public static Packet[] packetArray = new Packet[maxCount];

        private void mainForm_Load(object sender, EventArgs e)
        {
            #region 检查是否用户安装了winpcap
            if (!File.Exists(@"C:\Windows\System32\wpcap.dll"))
            {
                MessageBox.Show("运行此软件需要Winpcap的支持，请安装，然后再运行程序", "缺少支持文件");
                Process.Start("WinPcap_4_1_2.exe");
                this.Close();
            }
            #endregion

            #region 检查配置文件
            //如果配置文件丢失，则生成一个默认的配置文件
            if (!File.Exists(configClass.configFilePath))
            {
                configClass.reCreateConfigFile();
            }
            #endregion

            #region 检查过滤器
            //如果过滤器文件丢失，则警告，否则，添加过滤器到下拉框
            if (!File.Exists(filterClass.filterFilePath))
            {
                MessageBox.Show("wireSharkFilter.txt这个过滤器配置文件丢失，请检查！");
            }
            else
            {
                ArrayList structArrayList = filterClass.getFilters();
                foreach (filter filterA in structArrayList)
                {
                    toolStripCmbFilter.Items.Add(filterA.filterExpression);
                }
            }
            #endregion
            //自定义ListVIew排序方法
            this.listViewMain.ListViewItemSorter = new ListViewColumnSorter();

            //显示当前时间
            this.lblCurrentTime.Text = DateTime.Now.ToString("现在是yyyy年MM月dd日 hh:mm:ss");
            this.currentTimeTimer.Start();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void 捕获设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configForm cfm = new configForm();
            cfm.Show();
        }

        private void 过滤器设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filterForm frm = new filterForm();
            frm.Show();
        }

        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.停止ToolStripMenuItem.Enabled = true;
            this.开始ToolStripMenuItem.Enabled = false;
            //设置状态信息
            StringBuilder sb = new StringBuilder();
            sb.Append("当前网卡：" + SharpShark.configClass.NICName);
            sb.Append("    当前捕获模式:" + SharpShark.configClass.deviceModeDescription);
            sb.Append("    捕获正在进行……");
            this.lblStatus.Text = sb.ToString();
            //确定目标设备
            device = utility.getLiveDevice();
            device.OnPacketArrival += new PacketArrivalEventHandler(device_OnPacketArrival);
            int readTimeoutMilliseconds = 1000;
            //读取设备模式
            device.Open(SharpShark.configClass.deviceMode, readTimeoutMilliseconds);
            //设置过滤器
            if (this.toolStripCmbFilter.Text != "")
            {
                device.Filter = this.toolStripCmbFilter.Text.ToString();
            }
            //设置捕获数据包存储路径
            string dumpFilePath = configClass.fileStorePath;
            device.DumpOpen(dumpFilePath);
            device.StartCapture();
        }

        /// <summary>
        /// 在线捕获时  数据包到达时进行的操作
        /// </summary>
        private void device_OnPacketArrival(object sender, CaptureEventArgs e)
        {
            packetArrival(sender, e);
            //在线捕获的时候同时进行包的保存
            if (device.DumpOpened)
            {
                device.Dump(e.Packet);
            }
        }

        /// <summary>
        /// 从文件读的数据包到达时发生
        /// </summary>
        private void readPacketArrival(object sender, CaptureEventArgs e)
        {
            packetArrival(sender, e);
        }

        //文件读取和在线捕获都调用这一个
        private void packetArrival(object sender, CaptureEventArgs e)
        {
            Packet p = Packet.Parse(e.Packet.Data);//此处将包已经解码完毕
            //声明一个ListView的各个项
            int itemIndex = listViewMain.Items.Count;
            DateTime dateTime = e.Packet.Timeval.Date.ToLocalTime();
            string time = dateTime.TimeOfDay.ToString();
            string src = String.Empty;
            string dest = string.Empty;
            string protocol = String.Empty;
            string description = String.Empty;
            //传引用，填充信息
            SharpShark.utility.getInfoFromPacket(p, ref src, ref dest, ref protocol, ref description);
            //将数据包保存到内存中
            packetArray[itemIndex] = p;
            ListViewItem item = SharpShark.utility.parseToItem(itemIndex, time, src, dest, protocol, description);
            //增加一个ListItem项
            if (this.listViewMain.InvokeRequired)
            {
                delegateAddItem add = new delegateAddItem(addItem);
                this.Invoke(add, itemIndex, item);
            }
            else
            {
                this.listViewMain.Items.Insert(itemIndex, item);
            }
        }

        private void addItem(int itemIndex, ListViewItem item)
        {
            this.listViewMain.Items.Insert(itemIndex, item);
        }

        private void 停止ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            device.DumpFlush();
            device.DumpClose();
            device.StopCapture();
            device.Close();
            this.lblStatus.Text = "捕获已经停止";
            this.开始ToolStripMenuItem.Enabled = true;
            this.停止ToolStripMenuItem.Enabled = false;
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = String.Empty;
            if (ofDlg.ShowDialog() == DialogResult.OK)
            {
                filePath = ofDlg.FileName;
                this.lblStatus.Text = "当前文件：" + filePath;
                OfflinePcapDevice device = new OfflinePcapDevice(filePath);
                device.Open();
                device.OnPacketArrival += new PacketArrivalEventHandler(readPacketArrival);
                device.Capture();
                //此处数据包开始大量到达，引发 readPacketArrival 方法
                //TODO:当打开的数据包文件中的数据包数目在1000以上左右，窗体加载数据包，导致长时间无响应
                device.Close();
            }
        }

        private void listViewMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int packetNum = Int32.Parse(this.listViewMain.FocusedItem.Text);
            packetInfoDetailForm frm = new packetInfoDetailForm(packetNum);
            frm.Show();
        }

        private void currentTimeTimer_Tick(object sender, EventArgs e)
        {
            this.lblCurrentTime.Text = DateTime.Now.ToString("现在是yyyy年MM月dd日 hh:mm:ss");
        }

        private void listViewMain_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SharpShark.ListViewHelper.ListView_ColumnClick(sender, e);
        }

        private void 清空捕获结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listViewMain.Items.Clear();
        }

        private void 网络状况统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statisticForm frm = new statisticForm();
            frm.Show();
        }

        private void 捕获包统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();
            for (int i = 0; i < listViewMain.Items.Count; i++)
            {
                string tmpProtocal = listViewMain.Items[i].SubItems[4].Text;
                if (!ht.ContainsKey(tmpProtocal))
                {
                    ht.Add(tmpProtocal, 1);
                }
                else
                {
                    int count = (int)ht[tmpProtocal];
                    count++;
                    ht[tmpProtocal] = count;
                }
            }
            //HashTalbe转换为数组
            packetKind[] result = new packetKind[ht.Count];
            int arrayIndex = 0;
            foreach (Object obj in ht.Keys)
            {
                result[arrayIndex].protocol = obj.ToString();
                result[arrayIndex].count = (int)ht[obj];
                arrayIndex++;
            }
            statisticForm frm = new statisticForm(result);
            frm.Show();
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void 查看当前MACToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cmd.exe");
        }

        private void 搜索局域网主机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new hostListForm();
            frm.Show();
        }

        private void 帮助文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("SharpShark手册.html");
        }
    }

    /// <summary>
    /// 增加一个数据包项
    /// </summary>
    /// <param name="itemIndex"></param>
    /// <param name="item"></param>
    public delegate void delegateAddItem(int itemIndex, ListViewItem item);
}