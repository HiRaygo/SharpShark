using System;
using System.Windows.Forms;
using System.Xml;
using SharpPcap;

namespace SharpShark
{
    public static class configClass
    {
        public const string configFilePath = "config.xml";

        public static string NICName
        {
            get
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("SharpSharkConfig").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.Name == "NICName")
                        return xe.InnerText;
                }
                return String.Empty;
            }
            set
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("SharpSharkConfig").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.Name == "NICName")
                    {
                        xe.InnerText = value;
                        break;
                    }
                }
                xmlDoc.Save(configFilePath);
            }
        }

        public static string fileStorePath
        {
            get
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("SharpSharkConfig").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.Name == "fileStorePath")
                        return xe.InnerText;
                }
                return String.Empty;
            }
            set
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("SharpSharkConfig").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.Name == "fileStorePath")
                        xe.InnerText = value;
                }
                xmlDoc.Save(configFilePath);
            }
        }

        /// <summary>
        ///  Normal 或者 Promiscuous
        /// </summary>
        private static string deviceModeString
        {
            get
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("SharpSharkConfig").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.Name == "deviceModeString")
                    {
                        return xe.InnerText;
                    }
                }
                return String.Empty;
            }
            set
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFilePath);
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("SharpSharkConfig").ChildNodes;
                foreach (XmlNode xn in nodeList)
                {
                    XmlElement xe = (XmlElement)xn;
                    if (xe.Name == "deviceModeString")
                    {
                        xe.InnerText = value;
                    }
                }
                xmlDoc.Save(configFilePath);
            }
        }

        public static string deviceModeDescription
        {
            get
            {
                if (deviceModeString == "Normal")
                {
                    return "正常模式";
                }
                else
                {
                    return "混杂模式";
                }
            }
        }

        public static DeviceMode deviceMode
        {
            get
            {
                return (DeviceMode)Enum.Parse(typeof(DeviceMode), deviceModeString, true);
            }

            set
            {
                deviceModeString = value.ToString();
            }
        }

        //配置文件不存在时，重新创建一个。默认网卡名称为找到的第一个网卡的名称
        //默认路径为 C:\\SharpSharkDump
        public static void reCreateConfigFile()
        {
            var devices = LivePcapDeviceList.Instance;
            if (devices.Count < 1)
            {
                MessageBox.Show("未发现活动网卡，请检查网卡是否启用");
                return;
            }
            LivePcapDevice device = devices[0];//获取第一个取得的网卡

            XmlTextWriter writer = new XmlTextWriter(configFilePath, null);
            writer.Formatting = Formatting.Indented;
            //写入根元素
            writer.WriteStartElement("SharpSharkConfig");
            //加入子元素
            writer.WriteElementString("NICName", device.Interface.FriendlyName);
            writer.WriteElementString("fileStorePath", "C:\\SharpSharkDump.dmp");
            writer.WriteElementString("deviceModeString", "Normal");
            //关闭根元素，并书写结束标签
            writer.WriteEndElement();
            //将XML写入文件并且关闭XmlTextWriter
            writer.Close();
        }
    }
}