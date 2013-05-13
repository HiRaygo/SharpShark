using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using PacketDotNet;

namespace SharpShark
{
    public partial class hostListForm : Form
    {
        public hostListForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        const string commentFile = "comment.txt";

        private ArrayList packetArrayList=new ArrayList();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.lstHost.Items.Clear();
            this.progressBarTimer.Start();
            this.pbScan.Minimum = 0;
            this.pbScan.Maximum = 60;
            this.pbScan.Step = 1;
            Thread searchThread = new Thread(new ThreadStart(getHosts));
            searchThread.IsBackground = true;
            searchThread.Start();
        }

        private void getHosts()
        {
            //获取列表大概耗时35秒
            packetArrayList =utility.ARPBroadcast(utility.getLiveDevice());
            int ItemIndex = 0;
            foreach (Object obj in packetArrayList)
            {
                ARPPacket pkt = (ARPPacket)obj;
                string srcIP = pkt.SenderProtocolAddress.ToString();
                IPHostEntry entry = Dns.GetHostEntry(pkt.SenderProtocolAddress);
                string hostName = entry.HostName;
                //各项逐个添加的原因是解析HostName耗时不同
                ListViewItem tmp = new ListViewItem();
                tmp.Text = ItemIndex.ToString();
                tmp.SubItems.Add(hostName);
                tmp.SubItems.Add(pkt.SenderProtocolAddress.ToString());
                tmp.SubItems.Add(pkt.SenderHardwareAddress.ToString());
                //若源MAC已有对应注释，加载之
                string[] commentItem = File.ReadAllLines(commentFile);
                for (int i = 0; i < commentItem.Length; i++)
                {
                    if (commentItem[i].Substring(0, 12) == pkt.SenderHardwareAddress.ToString())
                    {
                        string tmpComment = commentItem[i].Substring(13);
                        tmp.SubItems.Add(tmpComment);
                        tmp.BackColor = Color.BurlyWood;
                    }
                }
                lstHost.Items.Insert(ItemIndex, tmp);
                ItemIndex++;
            }
            this.pbScan.Value = pbScan.Maximum;
            MessageBox.Show("数据包捕获完毕！");
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            this.pbScan.PerformStep();
        }

        private void btnSaveComment_Click(object sender, EventArgs e)
        {
            File.WriteAllText(commentFile,this.txtbComment.Text,System.Text.Encoding.Default);
        }

        private void hostListForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(commentFile))
            {
                this.txtbComment.Text = File.ReadAllText(commentFile,System.Text.Encoding.Default);
            }
        }

        private void txtbComment_DoubleClick(object sender, EventArgs e)
        {
            this.txtbComment.ReadOnly = !this.txtbComment.ReadOnly;
        }
    }
}