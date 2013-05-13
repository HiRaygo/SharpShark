namespace SharpShark
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空捕获结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.捕获ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.捕获包统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.网络状况统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.捕获设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.过滤器设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看当前MACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜索局域网主机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripLblFilter = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCmbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.listViewMain = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destination = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.protocol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.info = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofDlg = new System.Windows.Forms.OpenFileDialog();
            this.currentTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Font = new System.Drawing.Font("Tahoma", 12F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.捕获ToolStripMenuItem,
            this.统计ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStripMain.Size = new System.Drawing.Size(961, 29);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空捕获结果ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 清空捕获结果ToolStripMenuItem
            // 
            this.清空捕获结果ToolStripMenuItem.Name = "清空捕获结果ToolStripMenuItem";
            this.清空捕获结果ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.清空捕获结果ToolStripMenuItem.Text = "清空捕获结果";
            this.清空捕获结果ToolStripMenuItem.Click += new System.EventHandler(this.清空捕获结果ToolStripMenuItem_Click);
            // 
            // 捕获ToolStripMenuItem
            // 
            this.捕获ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.停止ToolStripMenuItem});
            this.捕获ToolStripMenuItem.Name = "捕获ToolStripMenuItem";
            this.捕获ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.捕获ToolStripMenuItem.Text = "捕获";
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.开始ToolStripMenuItem.Text = "开始";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 停止ToolStripMenuItem
            // 
            this.停止ToolStripMenuItem.Enabled = false;
            this.停止ToolStripMenuItem.Name = "停止ToolStripMenuItem";
            this.停止ToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.停止ToolStripMenuItem.Text = "停止";
            this.停止ToolStripMenuItem.Click += new System.EventHandler(this.停止ToolStripMenuItem_Click);
            // 
            // 统计ToolStripMenuItem
            // 
            this.统计ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.捕获包统计ToolStripMenuItem,
            this.网络状况统计ToolStripMenuItem});
            this.统计ToolStripMenuItem.Name = "统计ToolStripMenuItem";
            this.统计ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.统计ToolStripMenuItem.Text = "统计";
            // 
            // 捕获包统计ToolStripMenuItem
            // 
            this.捕获包统计ToolStripMenuItem.Name = "捕获包统计ToolStripMenuItem";
            this.捕获包统计ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.捕获包统计ToolStripMenuItem.Text = "捕获包统计";
            this.捕获包统计ToolStripMenuItem.Click += new System.EventHandler(this.捕获包统计ToolStripMenuItem_Click);
            // 
            // 网络状况统计ToolStripMenuItem
            // 
            this.网络状况统计ToolStripMenuItem.Name = "网络状况统计ToolStripMenuItem";
            this.网络状况统计ToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.网络状况统计ToolStripMenuItem.Text = "网络状况统计";
            this.网络状况统计ToolStripMenuItem.Click += new System.EventHandler(this.网络状况统计ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.捕获设置ToolStripMenuItem,
            this.过滤器设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 捕获设置ToolStripMenuItem
            // 
            this.捕获设置ToolStripMenuItem.Name = "捕获设置ToolStripMenuItem";
            this.捕获设置ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.捕获设置ToolStripMenuItem.Text = "捕获设置";
            this.捕获设置ToolStripMenuItem.Click += new System.EventHandler(this.捕获设置ToolStripMenuItem_Click);
            // 
            // 过滤器设置ToolStripMenuItem
            // 
            this.过滤器设置ToolStripMenuItem.Name = "过滤器设置ToolStripMenuItem";
            this.过滤器设置ToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.过滤器设置ToolStripMenuItem.Text = "过滤器设置";
            this.过滤器设置ToolStripMenuItem.Click += new System.EventHandler(this.过滤器设置ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.记事本ToolStripMenuItem,
            this.查看当前MACToolStripMenuItem,
            this.搜索局域网主机ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 记事本ToolStripMenuItem
            // 
            this.记事本ToolStripMenuItem.Name = "记事本ToolStripMenuItem";
            this.记事本ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.记事本ToolStripMenuItem.Text = "记事本";
            this.记事本ToolStripMenuItem.Click += new System.EventHandler(this.记事本ToolStripMenuItem_Click);
            // 
            // 查看当前MACToolStripMenuItem
            // 
            this.查看当前MACToolStripMenuItem.Name = "查看当前MACToolStripMenuItem";
            this.查看当前MACToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.查看当前MACToolStripMenuItem.Text = "CMD";
            this.查看当前MACToolStripMenuItem.Click += new System.EventHandler(this.查看当前MACToolStripMenuItem_Click);
            // 
            // 搜索局域网主机ToolStripMenuItem
            // 
            this.搜索局域网主机ToolStripMenuItem.Name = "搜索局域网主机ToolStripMenuItem";
            this.搜索局域网主机ToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.搜索局域网主机ToolStripMenuItem.Text = "搜索局域网主机";
            this.搜索局域网主机ToolStripMenuItem.Click += new System.EventHandler(this.搜索局域网主机ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助文档ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 23);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助文档ToolStripMenuItem
            // 
            this.帮助文档ToolStripMenuItem.Name = "帮助文档ToolStripMenuItem";
            this.帮助文档ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.帮助文档ToolStripMenuItem.Text = "帮助文档";
            this.帮助文档ToolStripMenuItem.Click += new System.EventHandler(this.帮助文档ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblFilter,
            this.toolStripCmbFilter});
            this.toolStripMain.Location = new System.Drawing.Point(0, 29);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(961, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripLblFilter
            // 
            this.toolStripLblFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLblFilter.Name = "toolStripLblFilter";
            this.toolStripLblFilter.Size = new System.Drawing.Size(53, 22);
            this.toolStripLblFilter.Text = "过滤器：";
            // 
            // toolStripCmbFilter
            // 
            this.toolStripCmbFilter.MaxDropDownItems = 100;
            this.toolStripCmbFilter.Name = "toolStripCmbFilter";
            this.toolStripCmbFilter.Size = new System.Drawing.Size(200, 25);
            // 
            // listViewMain
            // 
            this.listViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMain.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.time,
            this.source,
            this.destination,
            this.protocol,
            this.info});
            this.listViewMain.FullRowSelect = true;
            this.listViewMain.Location = new System.Drawing.Point(0, 57);
            this.listViewMain.Name = "listViewMain";
            this.listViewMain.Size = new System.Drawing.Size(961, 519);
            this.listViewMain.TabIndex = 2;
            this.listViewMain.UseCompatibleStateImageBehavior = false;
            this.listViewMain.View = System.Windows.Forms.View.Details;
            this.listViewMain.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewMain_ColumnClick);
            this.listViewMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewMain_MouseDoubleClick);
            // 
            // number
            // 
            this.number.Text = "序号";
            this.number.Width = 81;
            // 
            // time
            // 
            this.time.Text = "时间";
            this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.time.Width = 120;
            // 
            // source
            // 
            this.source.Text = "源";
            this.source.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.source.Width = 136;
            // 
            // destination
            // 
            this.destination.Text = "目标";
            this.destination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.destination.Width = 172;
            // 
            // protocol
            // 
            this.protocol.Text = "协议";
            this.protocol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.protocol.Width = 269;
            // 
            // info
            // 
            this.info.Text = "其它信息";
            this.info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.info.Width = 200;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Font = new System.Drawing.Font("宋体", 12F);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStatus});
            this.statusStripMain.Location = new System.Drawing.Point(0, 551);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(961, 22);
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "statusStripMain";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(946, 17);
            this.lblStatus.Spring = true;
            // 
            // ofDlg
            // 
            this.ofDlg.FileName = "dumpedFile";
            this.ofDlg.InitialDirectory = "C:\\";
            // 
            // currentTimeTimer
            // 
            this.currentTimeTimer.Interval = 1000;
            this.currentTimeTimer.Tick += new System.EventHandler(this.currentTimeTimer_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 573);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.listViewMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SharpShark";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 捕获ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        public System.Windows.Forms.ListView listViewMain;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader source;
        private System.Windows.Forms.ColumnHeader destination;
        private System.Windows.Forms.ColumnHeader protocol;
        private System.Windows.Forms.ColumnHeader info;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripMenuItem 捕获设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 过滤器设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLblFilter;
        private System.Windows.Forms.ToolStripComboBox toolStripCmbFilter;
        private System.Windows.Forms.OpenFileDialog ofDlg;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.Timer currentTimeTimer;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空捕获结果ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 捕获包统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 网络状况统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看当前MACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜索局域网主机ToolStripMenuItem;
    }
}