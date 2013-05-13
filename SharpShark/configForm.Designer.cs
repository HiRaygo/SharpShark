namespace SharpShark
{
    partial class configForm
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
            this.txtbStorePath = new System.Windows.Forms.TextBox();
            this.btnStorePath = new System.Windows.Forms.Button();
            this.cmbNIC = new System.Windows.Forms.ComboBox();
            this.fbdlgSavePath = new System.Windows.Forms.FolderBrowserDialog();
            this.lblNICInfo = new System.Windows.Forms.Label();
            this.lblDeviceMode = new System.Windows.Forms.Label();
            this.cmbDeviceMode = new System.Windows.Forms.ComboBox();
            this.lblNICs = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbStorePath
            // 
            this.txtbStorePath.Location = new System.Drawing.Point(11, 54);
            this.txtbStorePath.Margin = new System.Windows.Forms.Padding(4);
            this.txtbStorePath.Name = "txtbStorePath";
            this.txtbStorePath.ReadOnly = true;
            this.txtbStorePath.Size = new System.Drawing.Size(470, 26);
            this.txtbStorePath.TabIndex = 0;
            // 
            // btnStorePath
            // 
            this.btnStorePath.Location = new System.Drawing.Point(497, 49);
            this.btnStorePath.Name = "btnStorePath";
            this.btnStorePath.Size = new System.Drawing.Size(146, 32);
            this.btnStorePath.TabIndex = 1;
            this.btnStorePath.Text = "抓包文件存储路径";
            this.btnStorePath.UseVisualStyleBackColor = true;
            this.btnStorePath.Click += new System.EventHandler(this.btnStorePath_Click);
            // 
            // cmbNIC
            // 
            this.cmbNIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNIC.FormattingEnabled = true;
            this.cmbNIC.Location = new System.Drawing.Point(86, 12);
            this.cmbNIC.Name = "cmbNIC";
            this.cmbNIC.Size = new System.Drawing.Size(187, 24);
            this.cmbNIC.TabIndex = 2;
            this.cmbNIC.SelectedValueChanged += new System.EventHandler(this.cmbNIC_SelectedValueChanged);
            // 
            // fbdlgSavePath
            // 
            this.fbdlgSavePath.Description = "选择捕获文件存储路径";
            // 
            // lblNICInfo
            // 
            this.lblNICInfo.AutoSize = true;
            this.lblNICInfo.Location = new System.Drawing.Point(12, 94);
            this.lblNICInfo.Name = "lblNICInfo";
            this.lblNICInfo.Size = new System.Drawing.Size(88, 16);
            this.lblNICInfo.TabIndex = 4;
            this.lblNICInfo.Text = "网卡信息：";
            // 
            // lblDeviceMode
            // 
            this.lblDeviceMode.AutoSize = true;
            this.lblDeviceMode.Location = new System.Drawing.Point(393, 18);
            this.lblDeviceMode.Name = "lblDeviceMode";
            this.lblDeviceMode.Size = new System.Drawing.Size(72, 16);
            this.lblDeviceMode.TabIndex = 5;
            this.lblDeviceMode.Text = "设备模式";
            // 
            // cmbDeviceMode
            // 
            this.cmbDeviceMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceMode.FormattingEnabled = true;
            this.cmbDeviceMode.Items.AddRange(new object[] {
            "正常模式",
            "混杂模式"});
            this.cmbDeviceMode.Location = new System.Drawing.Point(471, 14);
            this.cmbDeviceMode.Name = "cmbDeviceMode";
            this.cmbDeviceMode.Size = new System.Drawing.Size(130, 24);
            this.cmbDeviceMode.TabIndex = 2;
            this.cmbDeviceMode.SelectedValueChanged += new System.EventHandler(this.cmbDeviceMode_SelectedValueChanged);
            // 
            // lblNICs
            // 
            this.lblNICs.AutoSize = true;
            this.lblNICs.Location = new System.Drawing.Point(8, 18);
            this.lblNICs.Name = "lblNICs";
            this.lblNICs.Size = new System.Drawing.Size(72, 16);
            this.lblNICs.TabIndex = 5;
            this.lblNICs.Text = "目标网卡";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(279, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 24);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(544, 416);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(99, 24);
            this.btnResetConfig.TabIndex = 1;
            this.btnResetConfig.Text = "全部重置";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // configForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 452);
            this.Controls.Add(this.lblNICs);
            this.Controls.Add(this.lblDeviceMode);
            this.Controls.Add(this.lblNICInfo);
            this.Controls.Add(this.cmbDeviceMode);
            this.Controls.Add(this.cmbNIC);
            this.Controls.Add(this.btnResetConfig);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnStorePath);
            this.Controls.Add(this.txtbStorePath);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "configForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置窗口";
            this.Load += new System.EventHandler(this.configForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbStorePath;
        private System.Windows.Forms.Button btnStorePath;
        private System.Windows.Forms.ComboBox cmbNIC;
        private System.Windows.Forms.FolderBrowserDialog fbdlgSavePath;
        private System.Windows.Forms.Label lblNICInfo;
        private System.Windows.Forms.Label lblDeviceMode;
        private System.Windows.Forms.ComboBox cmbDeviceMode;
        private System.Windows.Forms.Label lblNICs;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnResetConfig;
    }
}