namespace SharpShark
{
    partial class packetInfoDetailForm
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
            this.rtxtbHex = new System.Windows.Forms.RichTextBox();
            this.rtxtbASCII = new System.Windows.Forms.RichTextBox();
            this.lblEncoding = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.btnPrePacket = new System.Windows.Forms.Button();
            this.btnNextPacket = new System.Windows.Forms.Button();
            this.lblPacketID = new System.Windows.Forms.Label();
            this.lblPacketID0 = new System.Windows.Forms.Label();
            this.lblPacketTreeView = new System.Windows.Forms.Label();
            this.tvPacket = new System.Windows.Forms.TreeView();
            this.packetDetailContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.导出为TXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfDlgPacketDetail = new System.Windows.Forms.SaveFileDialog();
            this.packetDetailContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtbHex
            // 
            this.rtxtbHex.Location = new System.Drawing.Point(3, 24);
            this.rtxtbHex.Name = "rtxtbHex";
            this.rtxtbHex.Size = new System.Drawing.Size(350, 194);
            this.rtxtbHex.TabIndex = 12;
            this.rtxtbHex.Text = "";
            // 
            // rtxtbASCII
            // 
            this.rtxtbASCII.Location = new System.Drawing.Point(3, 236);
            this.rtxtbASCII.Name = "rtxtbASCII";
            this.rtxtbASCII.Size = new System.Drawing.Size(350, 266);
            this.rtxtbASCII.TabIndex = 13;
            this.rtxtbASCII.Text = "";
            // 
            // lblEncoding
            // 
            this.lblEncoding.AutoSize = true;
            this.lblEncoding.Location = new System.Drawing.Point(124, 221);
            this.lblEncoding.Name = "lblEncoding";
            this.lblEncoding.Size = new System.Drawing.Size(83, 12);
            this.lblEncoding.TabIndex = 11;
            this.lblEncoding.Text = "ASCII编码表示";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Location = new System.Drawing.Point(130, 9);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(77, 12);
            this.lblHex.TabIndex = 9;
            this.lblHex.Text = "十六进制数据";
            // 
            // btnPrePacket
            // 
            this.btnPrePacket.Location = new System.Drawing.Point(414, 32);
            this.btnPrePacket.Name = "btnPrePacket";
            this.btnPrePacket.Size = new System.Drawing.Size(75, 23);
            this.btnPrePacket.TabIndex = 15;
            this.btnPrePacket.Text = "上一个";
            this.btnPrePacket.UseVisualStyleBackColor = true;
            this.btnPrePacket.Click += new System.EventHandler(this.btnPrePacket_Click);
            // 
            // btnNextPacket
            // 
            this.btnNextPacket.Location = new System.Drawing.Point(607, 32);
            this.btnNextPacket.Name = "btnNextPacket";
            this.btnNextPacket.Size = new System.Drawing.Size(75, 23);
            this.btnNextPacket.TabIndex = 15;
            this.btnNextPacket.Text = "下一个";
            this.btnNextPacket.UseVisualStyleBackColor = true;
            this.btnNextPacket.Click += new System.EventHandler(this.btnNextPacket_Click);
            // 
            // lblPacketID
            // 
            this.lblPacketID.AutoSize = true;
            this.lblPacketID.Location = new System.Drawing.Point(557, 9);
            this.lblPacketID.Name = "lblPacketID";
            this.lblPacketID.Size = new System.Drawing.Size(53, 12);
            this.lblPacketID.TabIndex = 16;
            this.lblPacketID.Text = "数据包ID";
            // 
            // lblPacketID0
            // 
            this.lblPacketID0.AutoSize = true;
            this.lblPacketID0.Location = new System.Drawing.Point(468, 9);
            this.lblPacketID0.Name = "lblPacketID0";
            this.lblPacketID0.Size = new System.Drawing.Size(89, 12);
            this.lblPacketID0.TabIndex = 16;
            this.lblPacketID0.Text = "当前数据包ID：";
            // 
            // lblPacketTreeView
            // 
            this.lblPacketTreeView.AutoSize = true;
            this.lblPacketTreeView.Location = new System.Drawing.Point(514, 37);
            this.lblPacketTreeView.Name = "lblPacketTreeView";
            this.lblPacketTreeView.Size = new System.Drawing.Size(65, 12);
            this.lblPacketTreeView.TabIndex = 9;
            this.lblPacketTreeView.Text = "数据包详情";
            // 
            // tvPacket
            // 
            this.tvPacket.ContextMenuStrip = this.packetDetailContextMenu;
            this.tvPacket.Location = new System.Drawing.Point(359, 61);
            this.tvPacket.Name = "tvPacket";
            this.tvPacket.Size = new System.Drawing.Size(365, 441);
            this.tvPacket.TabIndex = 17;
            // 
            // packetDetailContextMenu
            // 
            this.packetDetailContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出为TXTToolStripMenuItem});
            this.packetDetailContextMenu.Name = "packetDetailContextMenu";
            this.packetDetailContextMenu.Size = new System.Drawing.Size(125, 26);
            // 
            // 导出为TXTToolStripMenuItem
            // 
            this.导出为TXTToolStripMenuItem.Name = "导出为TXTToolStripMenuItem";
            this.导出为TXTToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.导出为TXTToolStripMenuItem.Text = "导出为TXT";
            this.导出为TXTToolStripMenuItem.Click += new System.EventHandler(this.导出为TXTToolStripMenuItem_Click);
            // 
            // sfDlgPacketDetail
            // 
            this.sfDlgPacketDetail.DefaultExt = "txt";
            this.sfDlgPacketDetail.FileName = "数据包详情.txt";
            // 
            // packetInfoDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 514);
            this.Controls.Add(this.tvPacket);
            this.Controls.Add(this.lblPacketID0);
            this.Controls.Add(this.lblPacketID);
            this.Controls.Add(this.btnNextPacket);
            this.Controls.Add(this.btnPrePacket);
            this.Controls.Add(this.rtxtbHex);
            this.Controls.Add(this.rtxtbASCII);
            this.Controls.Add(this.lblEncoding);
            this.Controls.Add(this.lblPacketTreeView);
            this.Controls.Add(this.lblHex);
            this.Name = "packetInfoDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据包详细信息";
            this.Load += new System.EventHandler(this.packetInfoDetailForm_Load);
            this.packetDetailContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtbHex;
        private System.Windows.Forms.RichTextBox rtxtbASCII;
        private System.Windows.Forms.Label lblEncoding;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Button btnPrePacket;
        private System.Windows.Forms.Button btnNextPacket;
        private System.Windows.Forms.Label lblPacketID;
        private System.Windows.Forms.Label lblPacketID0;
        private System.Windows.Forms.Label lblPacketTreeView;
        private System.Windows.Forms.TreeView tvPacket;
        private System.Windows.Forms.ContextMenuStrip packetDetailContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 导出为TXTToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfDlgPacketDetail;
    }
}