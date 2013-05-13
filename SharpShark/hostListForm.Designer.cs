namespace SharpShark
{
    partial class hostListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstHost = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbScan = new System.Windows.Forms.ProgressBar();
            this.lblMSG = new System.Windows.Forms.Label();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSaveComment = new System.Windows.Forms.Button();
            this.txtbComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstHost
            // 
            this.lstHost.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.hostName,
            this.ip,
            this.mac,
            this.comment});
            this.lstHost.FullRowSelect = true;
            this.lstHost.Location = new System.Drawing.Point(3, 4);
            this.lstHost.Margin = new System.Windows.Forms.Padding(4);
            this.lstHost.Name = "lstHost";
            this.lstHost.Size = new System.Drawing.Size(738, 372);
            this.lstHost.TabIndex = 1;
            this.lstHost.UseCompatibleStateImageBehavior = false;
            this.lstHost.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 74;
            // 
            // hostName
            // 
            this.hostName.Text = "主机名";
            this.hostName.Width = 122;
            // 
            // ip
            // 
            this.ip.Text = "IP地址";
            this.ip.Width = 149;
            // 
            // mac
            // 
            this.mac.Text = "MAC地址";
            this.mac.Width = 166;
            // 
            // comment
            // 
            this.comment.Text = "备注";
            this.comment.Width = 185;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(269, 384);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbScan
            // 
            this.pbScan.Location = new System.Drawing.Point(12, 422);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(972, 23);
            this.pbScan.TabIndex = 3;
            // 
            // lblMSG
            // 
            this.lblMSG.AutoSize = true;
            this.lblMSG.ForeColor = System.Drawing.Color.Blue;
            this.lblMSG.Location = new System.Drawing.Point(351, 392);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(344, 16);
            this.lblMSG.TabIndex = 4;
            this.lblMSG.Text = "扫描耗时1分钟左右,请耐心等待，完成后有提示";
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Interval = 1000;
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // btnSaveComment
            // 
            this.btnSaveComment.Location = new System.Drawing.Point(824, 383);
            this.btnSaveComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveComment.Name = "btnSaveComment";
            this.btnSaveComment.Size = new System.Drawing.Size(115, 32);
            this.btnSaveComment.TabIndex = 2;
            this.btnSaveComment.Text = "保存备注列表";
            this.btnSaveComment.UseVisualStyleBackColor = true;
            this.btnSaveComment.Click += new System.EventHandler(this.btnSaveComment_Click);
            // 
            // txtbComment
            // 
            this.txtbComment.Location = new System.Drawing.Point(764, 40);
            this.txtbComment.Multiline = true;
            this.txtbComment.Name = "txtbComment";
            this.txtbComment.ReadOnly = true;
            this.txtbComment.Size = new System.Drawing.Size(220, 336);
            this.txtbComment.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtbComment, "双击以启用编辑");
            this.txtbComment.DoubleClick += new System.EventHandler(this.txtbComment_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(765, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "备注格式:MAC,注释";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Blue;
            this.lblInfo.Location = new System.Drawing.Point(9, 392);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(240, 16);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "目前仅支持192.168类型的局域网";
            // 
            // hostListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbComment);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.btnSaveComment);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstHost);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hostListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "局域网主机列表";
            this.Load += new System.EventHandler(this.hostListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHost;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ip;
        private System.Windows.Forms.ColumnHeader mac;
        private System.Windows.Forms.ProgressBar pbScan;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Timer progressBarTimer;
        private System.Windows.Forms.Button btnSaveComment;
        private System.Windows.Forms.ColumnHeader hostName;
        private System.Windows.Forms.TextBox txtbComment;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInfo;
    }
}