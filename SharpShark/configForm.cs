using System;
using System.Windows.Forms;
using System.Xml;
using SharpPcap;

namespace SharpShark
{
    public partial class configForm : Form
    {
        public configForm()
        {
            InitializeComponent();
        }

        private void configForm_Load(object sender, EventArgs e)
        {
            loadNIC();
            cmbDeviceMode.Text = SharpShark.configClass.deviceModeDescription;
            txtbStorePath.Text = SharpShark.configClass.fileStorePath;
        }

        private void cmbNIC_SelectedValueChanged(object sender, EventArgs e)
        {
            //根据用户的选择，显示对应网卡的信息
            var devices = LivePcapDeviceList.Instance;
            foreach (LivePcapDevice dev in devices)
            {
                if (cmbNIC.Text == dev.Interface.FriendlyName)
                {
                    lblNICInfo.Text = dev.Interface.ToString();
                }
            }
            //保存要设置为默认网卡的网卡friendly name
            configClass.NICName = cmbNIC.Text;
        }

        private void btnStorePath_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fbdlgSavePath.ShowDialog())
            {
                txtbStorePath.Text = fbdlgSavePath.SelectedPath;
                configClass.fileStorePath = txtbStorePath.Text;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SharpPcap.LivePcapDeviceList.Instance = null;
            loadNIC();
        }

        /// <summary>
        /// 加载网卡信息
        /// </summary>
        private void loadNIC()
        {
            var devices = LivePcapDeviceList.Instance;
            string storedNICName = SharpShark.configClass.NICName;
            if (devices.Count < 1)
            {
                MessageBox.Show("未找到网卡，请检查网卡是否启用");
                return;
            }
            cmbNIC.Items.Clear();
            foreach (LivePcapDevice dev in devices)
            {
                cmbNIC.Items.Add(dev.Interface.FriendlyName);
                if (storedNICName == dev.Interface.FriendlyName)
                {
                    cmbNIC.Text = storedNICName;
                }
            }
            //如果存储的网卡名称不存在当前获取的网卡列表中
            if (cmbNIC.Text == String.Empty)
            {
                cmbNIC.Text = devices[0].Interface.FriendlyName;
            }
        }

        private void cmbDeviceMode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbDeviceMode.Text == "正常模式")
            {
                SharpShark.configClass.deviceMode = DeviceMode.Normal;
            }
            if (cmbDeviceMode.Text == "混杂模式")
            {
                SharpShark.configClass.deviceMode = DeviceMode.Promiscuous;
            }
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            SharpShark.configClass.reCreateConfigFile();
        }
    }
}