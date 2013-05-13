using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using PacketDotNet;
using SharpPcap;

namespace SharpShark
{
    /// <summary>
    /// SharpShark工具类
    /// </summary>
    static class utility
    {
        /// <summary>
        /// 获取用户选择的或者默认的LivePcapDevice
        /// </summary>
        /// <returns></returns>
        internal static LivePcapDevice getLiveDevice()
        {
            var devices = LivePcapDeviceList.Instance;
            LivePcapDevice device = null;
            if (devices.Count < 1)
            {
                MessageBox.Show("未发现活动网卡，请检查网卡是否启用");
            }
            int index = 0;
            for (int i = 0; i < devices.Count; i++)
            {
                if (devices[i].Interface.FriendlyName == configClass.NICName)
                {
                    index = i;
                    break;
                }
            }
            device = devices[index];
            return device;
        }

        //获取当前程序使用的SharpPcap.DLL的版本号
        public static string getVersionString()
        {
            //参数指定的是Version类，此方法就是获取定义Version类的程序集，也就是SharpPcap.dll的版本
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetAssembly(typeof(SharpPcap.Version));
            string versionString = asm.GetName().Version.ToString();
            return versionString;
        }

        public static void WriteLine(ref TextBox tb, String str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(tb.Text);
            sb.Append(str);
            sb.Append("\r\n");
            Control.CheckForIllegalCrossThreadCalls = false;
            tb.Text = sb.ToString();
        }

        /// <summary>
        /// 从一个数据包中读取并填充需要的参数
        /// </summary>
        /// <param name="packet"></param>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        /// <param name="protocol"></param>
        /// <param name="description"></param>
        internal static void getInfoFromPacket
            (Packet packet, ref string src, ref string dest, ref string protocol, ref string description)
        {
            if (packet == null)
            {
                return;
            }
            description = packet.ToString();
            if (packet is EthernetPacket)
            {
                //这样是为了保护原来的Packet被强制类型转换后无法恢复
                Packet tmpPacket = packet;
                EthernetPacket p = (EthernetPacket)tmpPacket;
                src = p.SourceHwAddress.ToString();
                dest = p.DestinationHwAddress.ToString();
                protocol = "0X" + p.Type.ToString("X");
            }
            if (packet is ARPPacket)
            {
                Packet tmpPacket = packet;
                ARPPacket p = (ARPPacket)tmpPacket;
                src = p.SenderProtocolAddress.ToString();
                dest = p.TargetProtocolAddress.ToString();
                protocol = "0X" + p.ProtocolAddressType.ToString("X");
            }
            if (packet is IpPacket)
            {
                Packet tmpPacket = packet;
                IpPacket p = (IpPacket)tmpPacket;
                src = p.SourceAddress.ToString();
                dest = p.DestinationAddress.ToString();
                protocol = p.Protocol.ToString();
            }
            //采用递归，检查一边包的子包
            getInfoFromPacket(packet.PayloadPacket, ref src, ref  dest, ref  protocol, ref  description);
        }

        internal static string readableInfo(Packet p, System.Text.Encoding encode)
        {
            if (p.PayloadData != null)
            {
                return encode.GetString(p.PayloadData);
            }
            return encode.GetString(p.Bytes);
        }

        /// <summary>
        /// 将一个数据包的信息编码成一个ListView控件的ListViewItem
        /// </summary>
        public static ListViewItem parseToItem
                    (int id, string time, string src, string dest, string protocol, string description)
        {
            ListViewItem Item = new ListViewItem();
            Item.Text = id.ToString();
            Item.SubItems.Add(time.ToString());
            Item.SubItems.Add(src.ToString());
            Item.SubItems.Add(dest.ToString());
            Item.SubItems.Add(protocol.ToString());
            Item.SubItems.Add(description.ToString());
            return Item;
        }

        public static string bytesToAsciiStr(byte[] data)
        {
            string ascii = "";
            for (int i = 1; i <= data.Length; i++)
            {
                if (data[i - 1] < 0x21 || data[i - 1] > 0x7e)
                {
                    ascii += ".";
                }
                else
                {
                    ascii += Encoding.ASCII.GetString(new byte[1] { data[i - 1] });
                }
            }
            return ascii;
        }

        /// <summary>
        /// 将一个对象的所有字段转换成一个TreeNode数组
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static TreeNode[] ObjToTreeNode(Object obj)
        {
            Type t = obj.GetType();
            PropertyInfo[] pis = t.GetProperties();
            TreeNode[] nodes = new TreeNode[pis.Length];
            for (int i = 0; i < pis.Length; i++)
            {
                string info = pis[i].Name + ":";
                nodes[i] = new TreeNode(info);
            }
            return nodes;
        }

        //发送ARP广播，返回192.168局域网中其他计算机的ARP相应数据包
        public static ArrayList ARPBroadcast(LivePcapDevice device)
        {
            ArrayList tmpArrayList = new ArrayList();
            PhysicalAddress localMAC = device.Interface.MacAddress;
            //这是我们伪造的一个IP
            IPAddress srcIP = IPAddress.Parse("192.168.3.3");
            String arpFilter = "arp and ether dst " + localMAC.ToString();

            //open the device with 20ms timeout
            device.Open(DeviceMode.Normal, 20);
            device.Filter = arpFilter;
            IPAddress destIP;
            SharpPcap.ARP tmpArp=new ARP();
            //发送65535个数据包耗时30秒，这30秒内到达的数据包由网卡缓存
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    destIP = IPAddress.Parse("192.168." + i.ToString() + "." + j.ToString());
                    //request是Packet类型
                    var request = tmpArp.BuildRequest(destIP, localMAC, srcIP);
                    //发送数据包到网络中
                    device.SendPacket(request);
                }
            }
            DateTime StartTime = DateTime.Now;
            DateTime endTime = StartTime.AddSeconds(5);
            PacketDotNet.ARPPacket arpPacket = null;
            //接收5秒钟数据包，然后闪人
            while (DateTime.Now <= endTime)
            {
                var reply = device.GetNextPacket();
                if (reply == null) 
                    continue;
                var packet = PacketDotNet.Packet.ParsePacket(reply);
                arpPacket = PacketDotNet.ARPPacket.GetEncapsulated(packet);
                if (arpPacket == null)
                {
                    continue;
                }
                else
                {
                    //exists判断是否ARP回应包存在重复
                    bool exists = false;
                    foreach (Object obj in tmpArrayList)
                    {
                        ARPPacket tmp=(ARPPacket)obj;
                        if (arpPacket.SenderHardwareAddress==tmp.SenderHardwareAddress)
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (exists == false)
                    {
                        tmpArrayList.Add(arpPacket);
                    }
                }
            }
            device.Close();
            return tmpArrayList;
        }

        #region 从文件中读包的方法
        //TODO：从文件中读包的方法,尚未实现
        internal static byte[] readPacket(string dumpFilePath, int packetNum)
        {
            //帧开始控制字符SOH，十六进制为01
            //帧结束EOT  十六进制为04
            //数据中出现控制字符时，需要在其前面插入一个转义字符ESC  十六进制为1B
            byte[] fileBytes = File.ReadAllBytes(dumpFilePath);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < fileBytes.Length; i++)
            {
                sb.Append(fileBytes[i]);
            }
            string tmp = sb.ToString();
            return null;
        }
        #endregion

        public static IPAddress destIP { get; set; }
    }
}