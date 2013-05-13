using System;
using System.Reflection;
using System.Windows.Forms;
using PacketDotNet;

namespace SharpShark
{
    class PacketToNodeClass
    {
        public TreeNode[,] nodes = new TreeNode[5, 20];
        public int num = 0;      //记录包的层次深度
        public void PacketToNode(Packet p)
        {
            //string packetName = p.GetType().ToString();
            //this.nodes[this.num][0] = new TreeNode(packetName);
            //Type t = p.GetType();
            //PropertyInfo[] pis = t.GetProperties();
            //for (int i = 0; i < pis.Length; i++)
            //{
            //    string name = pis[i].Name;
            //    Object value=pis[i].GetValue(p,null);
            //    string strValue = value.ToString();
            //    this.nodes[this.num][i+1] = new TreeNode(name+strValue);
            //}
            //this.num = this.num + 1;
            //if(p.PayloadPacket!=null)
            //{
            //    this.PacketToNode(p.PayloadPacket);
            //}

            #region 第三次，直接进行叶子节点上包类型的匹配。失败，因为是包中含包
            //我们所能捕获的包实际上都是EthernetPacket
            //packet = (EthernetPacket)p;
            //    if (p is ARPPacket)
            //    {
            //        p = (ARPPacket)p;
            //        return SharpShark.utility.ObjToTreeNode(p);
            //    }
            //    if (p is TcpPacket)
            //    {
            //        p = (TcpPacket)p;
            //        return SharpShark.utility.ObjToTreeNode(p);
            //    }
            //    if (p is UdpPacket)
            //    {
            //        p = (UdpPacket)p;
            //        return SharpShark.utility.ObjToTreeNode(p);
            //    }
            //    if (p is EthernetPacket)
            //    {
            //        p = (EthernetPacket)p;
            //        return SharpShark.utility.ObjToTreeNode(p);
            //    }
            //    return SharpShark.utility.ObjToTreeNode(p);
            //}
            #endregion
            #region 第二次，利用 is ,试图对包进行从父类到子类的类型匹配，因为包的继承关系和归属关系不对应，失败
            //public static TreeNode[] ethernetPacketToNode(Packet p)
            //{
            //    if (p is IPv4Packet)
            //    {
            //        return IPv4PacketToNode(p);
            //    }
            //    if (p is IPv6Packet)
            //    {
            //        return IPv6PacketToNode(p);
            //    }
            //    if (p is ARPPacket)
            //    {
            //        return ARPPacketToNode(p);
            //    }
            //    if (p is LLDPPacket)
            //    {
            //        return LLDPPacketToNode(p);
            //    }
            //    if (p is PPPoEPacket)
            //    {
            //        return PPPoEPacketToNode(p);
            //    }
            //    return SharpShark.utility.ObjToTreeNode(p);
            //}

            //public static TreeNode[] IPv4PacketToNode(Packet p)
            //{

            //    return SharpShark.utility.ObjToTreeNode(p);
            //}

            //public static TreeNode[] IPv6PacketToNode(Packet p)
            //{

            //    return SharpShark.utility.ObjToTreeNode(p);
            //}

            //public static TreeNode[] ARPPacketToNode(Packet p)
            //{

            //    return SharpShark.utility.ObjToTreeNode(p);
            //}

            //public static TreeNode[] LLDPPacketToNode(Packet p)
            //{

            //    return SharpShark.utility.ObjToTreeNode(p);
            //}

            //public static TreeNode[] PPPoEPacketToNode(Packet p)
            //{

            //    return SharpShark.utility.ObjToTreeNode(p);
            //}
            #endregion
            #region 第一次，利用反射进行类型匹配，失败
            //public void ethernetType()
            //{
            //    nodeArray[0][0]=new TreeNode("Ethernet数据包");
            //    TreeNode[] tmp=addToNode(packet,typeof(EthernetPacket));
            //    for (int i = 0; i < tmp.Length; i++)
            //    {
            //        nodeArray[0][i+1] = tmp[i];
            //    }
            //    switch (packet.Type)
            //    {
            //        case EthernetPacketType.IpV4:
            //            packet=(IpPacket)packet;
            //            break;
            //        case EthernetPacketType.IpV6:
            //            break;
            //        case EthernetPacketType.Arp:
            //            break;
            //        case EthernetPacketType.LLDP:
            //            break;
            //        case EthernetPacketType.PointToPointProtocolOverEthernetSessionStage:
            //            break;
            //        default: // consider the sub-packet to be a byte array
            //            break;
            //    }
            //}

            //public void ippacketType()
            //{
            //    switch (ProtocolType)
            //    {
            //        case IPProtocolType.TCP:
            //            payloadPacketOrData.ThePacket = new TcpPacket(payload,
            //                                                          ParentPacket);
            //            break;
            //        case IPProtocolType.UDP:
            //            payloadPacketOrData.ThePacket = new UdpPacket(payload,
            //                                                          ParentPacket);
            //            break;
            //        case IPProtocolType.ICMP:
            //            payloadPacketOrData.ThePacket = new ICMPv4Packet(payload,
            //                                                             ParentPacket);
            //            break;
            //        case IPProtocolType.ICMPV6:
            //            payloadPacketOrData.ThePacket = new ICMPv6Packet(payload,
            //                                                             ParentPacket);
            //            break;
            //        case IPProtocolType.IGMP:
            //            payloadPacketOrData.ThePacket = new IGMPv2Packet(payload,
            //                                                             ParentPacket);
            //            break;
            //        // NOTE: new payload parsing entries go here
            //        default:
            //            payloadPacketOrData.TheByteArraySegment = payload;
            //            break;
            //    }
            //}
            #endregion
        }
    }
}