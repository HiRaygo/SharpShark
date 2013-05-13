using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using SharpPcap;
using System.Drawing;

namespace SharpShark
{
    public partial class statisticForm : Form
    {
        public statisticForm()
        {
            InitializeComponent();
            this.picBox.Image = PieChart.drawPicture(400,400,"暂无统计数据");
        }

        public statisticForm(packetKind[] items)
        {
            InitializeComponent();
            this.picBox.Image = PieChart.render("数据包统计图", DateTime.Now.TimeOfDay.ToString(), 500, 400, items);
        }

        LivePcapDevice device = null;

        private void btnStart_Click(object sender, EventArgs e)
        {
            device = utility.getLiveDevice();
            device.OnPcapStatistics +=
                new StatisticsModeEventHandler(device_OnPcapStatistics);
            device.Open();
            device.Mode = CaptureMode.Statistics;
            device.OnPacketArrival += new PacketArrivalEventHandler(arrival);
            device.StartCapture();
        }

        public static void arrival(object sender, CaptureEventArgs e)
        {

        }

        static ulong oldSec = 0;
        static ulong oldUsec = 0;
        /// <summary>
        /// 获取一个pcap状态对象，计算bps和pps
        /// </summary>
        private void device_OnPcapStatistics(object sender, StatisticsModeEventArgs e)
        {
            // Calculate the delay in microseconds from the last sample.
            // This value is obtained from the timestamp that's associated with the sample.
            ulong delay = (e.Statistics.Timeval.Seconds - oldSec) * 1000000 - oldUsec + e.Statistics.Timeval.MicroSeconds;

            // Bits per second
            ulong bps = ((ulong)e.Statistics.RecievedBytes * 8 * 1000000) / delay;
            /*                                       ^       ^
                                                     |       |
                                                     |       | 
                                                     |       |
                            converts bytes in bits --        |
                                                             |
                        delay is expressed in microseconds --
            */

            // Get the number of Packets per second
            ulong pps = ((ulong)e.Statistics.RecievedPackets * 1000000) / delay;

            // Convert the timestamp to readable format
            var ts = e.Statistics.Timeval.Date.ToLongTimeString();
            string info = "时间：" + ts + ";   每秒" + bps + "字节;   每秒" + pps + "个数据包";
            utility.WriteLine(ref this.txtbStatistic, info);
            //存储当前时间戳
            oldSec = e.Statistics.Timeval.Seconds;
            oldUsec = e.Statistics.Timeval.MicroSeconds;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            device.StopCapture();
            device.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string path = String.Empty;
            if (sfDlgStatistic.ShowDialog() == DialogResult.OK)
            {
                path = sfDlgStatistic.FileName;
                if (File.Exists(path))
                    File.Delete(path);
                FileStream fs = File.Create(path);
                byte[] info = new UTF8Encoding(true).GetBytes(txtbStatistic.Text);
                fs.Write(info, 0, info.Length);
                fs.Flush();
                fs.Close();
            }
        }

        private void statisticForm_Load(object sender, EventArgs e)
        {

        }
    }
}