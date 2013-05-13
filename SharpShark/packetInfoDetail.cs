using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using PacketDotNet;
using xf;

namespace SharpShark
{
    public partial class packetInfoDetailForm : Form
    {
        private int currentPacketID;

        public packetInfoDetailForm(int num)
        {
            InitializeComponent();
            currentPacketID = num;
        }

        private void packetInfoDetailForm_Load(object sender, EventArgs e)
        {
            loadPacket(currentPacketID);
        }

        private void loadPacket(int packetNum)
        {
            Packet p = mainForm.packetArray[packetNum];

            #region 前后浏览数据包
            this.lblPacketID.Text = packetNum.ToString();
            //当前包为第一个，则不显示“前一个”按钮;为最后一个，则不显示“下一个”按钮
            this.btnPrePacket.Visible = true;
            this.btnNextPacket.Visible = true;
            if (packetNum == 0)
            {
                this.btnPrePacket.Visible = false;
            }
            if (packetNum == mainForm.packetArray.Length - 1)
            {
                this.btnNextPacket.Visible = false;
            }
            #endregion

            this.rtxtbHex.Text = xf.xfEncoding.byteArrayToHexStr(p.Bytes, convertType.EachByte);
            if (p.Bytes != null)
            {
                this.rtxtbASCII.Text = SharpShark.utility.bytesToAsciiStr(p.Bytes);
            }
            //清空TreeView，下面开始给TreeView增加TreeNode
            this.tvPacket.Nodes.Clear();
            packetParseToNode(p, 0);
        }

        //以此控制包的层次
        private void packetParseToNode(Packet p, int rootNodeNumber)
        {
            if (p == null)
            {
                return;
            }
            addNodes(p, rootNodeNumber);
            packetParseToNode(p.PayloadPacket, rootNodeNumber + 1);
        }

        /// <summary>
        /// 为当前的TreeView增加节点（节点信息来自编码的包的字段）
        /// </summary>
        /// <param name="p">要解码的包</param>
        /// <param name="deepth">当前各个项的根节点的序号</param>
        private void addNodes(Packet p, int deepth)
        {
            //增加包的类型名称并切掉命名空间前缀
            string packetName = p.GetType().ToString();
            packetName = packetName.Substring(13, packetName.Length - 13);
            TreeNode rootNode = new TreeNode(packetName);
            this.tvPacket.Nodes.Add(rootNode);
            Type t = p.GetType();
            PropertyInfo[] pis = t.GetProperties();
            //输出包的各个属性
            for (int i = 0; i < pis.Length; i++)
            {
                string name = pis[i].Name;
                Object value = pis[i].GetValue(p, null);
                //空属性不输出；Color属性不输出；类型为System.Byte[]的项不输出
                if (value != null && name != "Color" && pis[i].PropertyType.FullName != "System.Byte[]")
                {
                    string strValue = value.ToString();
                    this.tvPacket.Nodes[deepth].Nodes.Add(new TreeNode(name + " : " + strValue));
                }
            }
        }

        private void btnPrePacket_Click(object sender, EventArgs e)
        {
            currentPacketID = currentPacketID - 1;
            loadPacket(currentPacketID);
        }

        private void btnNextPacket_Click(object sender, EventArgs e)
        {
            currentPacketID = currentPacketID + 1;
            loadPacket(currentPacketID);
        }

        private void 导出为TXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfDlgPacketDetail.ShowDialog() == DialogResult.OK)
            {
                string filePath = sfDlgPacketDetail.FileName;
                StreamWriter sw = new StreamWriter(filePath);
                for (int i = 0; i < tvPacket.Nodes.Count; i++)
                {
                    sw.WriteLine(tvPacket.Nodes[i].Text.ToString());
                    for (int j = 0; j < tvPacket.Nodes[i].Nodes.Count; j++)
                    {
                        sw.WriteLine("      " + tvPacket.Nodes[i].Nodes[j].Text.ToString());
                    }
                }
                sw.Flush();
                sw.Close();
            }
        }
    }
}