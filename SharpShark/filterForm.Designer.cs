namespace SharpShark
{
    partial class filterForm
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
            this.gpbFilterEdit = new System.Windows.Forms.GroupBox();
            this.btnFilterDelete = new System.Windows.Forms.Button();
            this.btnFilterNew = new System.Windows.Forms.Button();
            this.gpbCaptureFilter = new System.Windows.Forms.GroupBox();
            this.lstbFilter = new System.Windows.Forms.ListBox();
            this.gpbFilterProperty = new System.Windows.Forms.GroupBox();
            this.txtbFilterExpression = new System.Windows.Forms.TextBox();
            this.lblFilterExpression = new System.Windows.Forms.Label();
            this.txtbFilterName = new System.Windows.Forms.TextBox();
            this.lblFilterName = new System.Windows.Forms.Label();
            this.btnFilterHelp = new System.Windows.Forms.Button();
            this.btnFilterOK = new System.Windows.Forms.Button();
            this.btnFilterCancel = new System.Windows.Forms.Button();
            this.gpbFilterEdit.SuspendLayout();
            this.gpbCaptureFilter.SuspendLayout();
            this.gpbFilterProperty.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFilterEdit
            // 
            this.gpbFilterEdit.Controls.Add(this.btnFilterDelete);
            this.gpbFilterEdit.Controls.Add(this.btnFilterNew);
            this.gpbFilterEdit.Location = new System.Drawing.Point(6, 2);
            this.gpbFilterEdit.Margin = new System.Windows.Forms.Padding(4);
            this.gpbFilterEdit.Name = "gpbFilterEdit";
            this.gpbFilterEdit.Padding = new System.Windows.Forms.Padding(4);
            this.gpbFilterEdit.Size = new System.Drawing.Size(91, 326);
            this.gpbFilterEdit.TabIndex = 0;
            this.gpbFilterEdit.TabStop = false;
            this.gpbFilterEdit.Text = "编辑";
            // 
            // btnFilterDelete
            // 
            this.btnFilterDelete.Location = new System.Drawing.Point(11, 224);
            this.btnFilterDelete.Name = "btnFilterDelete";
            this.btnFilterDelete.Size = new System.Drawing.Size(75, 23);
            this.btnFilterDelete.TabIndex = 0;
            this.btnFilterDelete.Text = "删除";
            this.btnFilterDelete.UseVisualStyleBackColor = true;
            this.btnFilterDelete.Click += new System.EventHandler(this.btnFilterDelete_Click);
            // 
            // btnFilterNew
            // 
            this.btnFilterNew.Location = new System.Drawing.Point(11, 54);
            this.btnFilterNew.Name = "btnFilterNew";
            this.btnFilterNew.Size = new System.Drawing.Size(75, 23);
            this.btnFilterNew.TabIndex = 0;
            this.btnFilterNew.Text = "新建";
            this.btnFilterNew.UseVisualStyleBackColor = true;
            this.btnFilterNew.Click += new System.EventHandler(this.btnFilterNew_Click);
            // 
            // gpbCaptureFilter
            // 
            this.gpbCaptureFilter.Controls.Add(this.lstbFilter);
            this.gpbCaptureFilter.Location = new System.Drawing.Point(117, 2);
            this.gpbCaptureFilter.Name = "gpbCaptureFilter";
            this.gpbCaptureFilter.Size = new System.Drawing.Size(379, 326);
            this.gpbCaptureFilter.TabIndex = 1;
            this.gpbCaptureFilter.TabStop = false;
            this.gpbCaptureFilter.Text = "过滤器";
            // 
            // lstbFilter
            // 
            this.lstbFilter.FormattingEnabled = true;
            this.lstbFilter.ItemHeight = 16;
            this.lstbFilter.Location = new System.Drawing.Point(7, 26);
            this.lstbFilter.Name = "lstbFilter";
            this.lstbFilter.Size = new System.Drawing.Size(366, 292);
            this.lstbFilter.TabIndex = 0;
            this.lstbFilter.SelectedValueChanged += new System.EventHandler(this.lstbFilter_SelectedValueChanged);
            // 
            // gpbFilterProperty
            // 
            this.gpbFilterProperty.Controls.Add(this.txtbFilterExpression);
            this.gpbFilterProperty.Controls.Add(this.lblFilterExpression);
            this.gpbFilterProperty.Controls.Add(this.txtbFilterName);
            this.gpbFilterProperty.Controls.Add(this.lblFilterName);
            this.gpbFilterProperty.Location = new System.Drawing.Point(6, 335);
            this.gpbFilterProperty.Name = "gpbFilterProperty";
            this.gpbFilterProperty.Size = new System.Drawing.Size(490, 97);
            this.gpbFilterProperty.TabIndex = 2;
            this.gpbFilterProperty.TabStop = false;
            this.gpbFilterProperty.Text = "过滤器属性";
            // 
            // txtbFilterExpression
            // 
            this.txtbFilterExpression.Location = new System.Drawing.Point(118, 55);
            this.txtbFilterExpression.Name = "txtbFilterExpression";
            this.txtbFilterExpression.Size = new System.Drawing.Size(351, 26);
            this.txtbFilterExpression.TabIndex = 1;
            this.txtbFilterExpression.Enter += new System.EventHandler(this.txtbFilterExpression_Enter);
            // 
            // lblFilterExpression
            // 
            this.lblFilterExpression.AutoSize = true;
            this.lblFilterExpression.Location = new System.Drawing.Point(11, 58);
            this.lblFilterExpression.Name = "lblFilterExpression";
            this.lblFilterExpression.Size = new System.Drawing.Size(112, 16);
            this.lblFilterExpression.TabIndex = 0;
            this.lblFilterExpression.Text = "过滤器表达式:";
            // 
            // txtbFilterName
            // 
            this.txtbFilterName.Location = new System.Drawing.Point(118, 23);
            this.txtbFilterName.Name = "txtbFilterName";
            this.txtbFilterName.Size = new System.Drawing.Size(351, 26);
            this.txtbFilterName.TabIndex = 1;
            this.txtbFilterName.Enter += new System.EventHandler(this.txtbFilterName_Enter);
            // 
            // lblFilterName
            // 
            this.lblFilterName.AutoSize = true;
            this.lblFilterName.Location = new System.Drawing.Point(11, 26);
            this.lblFilterName.Name = "lblFilterName";
            this.lblFilterName.Size = new System.Drawing.Size(96, 16);
            this.lblFilterName.TabIndex = 0;
            this.lblFilterName.Text = "过滤器名称:";
            // 
            // btnFilterHelp
            // 
            this.btnFilterHelp.Location = new System.Drawing.Point(20, 444);
            this.btnFilterHelp.Name = "btnFilterHelp";
            this.btnFilterHelp.Size = new System.Drawing.Size(75, 23);
            this.btnFilterHelp.TabIndex = 3;
            this.btnFilterHelp.Text = "帮助";
            this.btnFilterHelp.UseVisualStyleBackColor = true;
            // 
            // btnFilterOK
            // 
            this.btnFilterOK.Location = new System.Drawing.Point(303, 444);
            this.btnFilterOK.Name = "btnFilterOK";
            this.btnFilterOK.Size = new System.Drawing.Size(83, 23);
            this.btnFilterOK.TabIndex = 3;
            this.btnFilterOK.Text = "保存修改";
            this.btnFilterOK.UseVisualStyleBackColor = true;
            this.btnFilterOK.Click += new System.EventHandler(this.btnFilterOK_Click);
            // 
            // btnFilterCancel
            // 
            this.btnFilterCancel.Location = new System.Drawing.Point(415, 444);
            this.btnFilterCancel.Name = "btnFilterCancel";
            this.btnFilterCancel.Size = new System.Drawing.Size(75, 23);
            this.btnFilterCancel.TabIndex = 3;
            this.btnFilterCancel.Text = "取消";
            this.btnFilterCancel.UseVisualStyleBackColor = true;
            this.btnFilterCancel.Click += new System.EventHandler(this.btnFilterCancel_Click);
            // 
            // filterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 479);
            this.Controls.Add(this.btnFilterCancel);
            this.Controls.Add(this.btnFilterOK);
            this.Controls.Add(this.btnFilterHelp);
            this.Controls.Add(this.gpbFilterProperty);
            this.Controls.Add(this.gpbCaptureFilter);
            this.Controls.Add(this.gpbFilterEdit);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "filterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "过滤器设置";
            this.Load += new System.EventHandler(this.filterForm_Load);
            this.gpbFilterEdit.ResumeLayout(false);
            this.gpbCaptureFilter.ResumeLayout(false);
            this.gpbFilterProperty.ResumeLayout(false);
            this.gpbFilterProperty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFilterEdit;
        private System.Windows.Forms.Button btnFilterNew;
        private System.Windows.Forms.Button btnFilterDelete;
        private System.Windows.Forms.GroupBox gpbCaptureFilter;
        private System.Windows.Forms.ListBox lstbFilter;
        private System.Windows.Forms.GroupBox gpbFilterProperty;
        private System.Windows.Forms.TextBox txtbFilterExpression;
        private System.Windows.Forms.Label lblFilterExpression;
        private System.Windows.Forms.TextBox txtbFilterName;
        private System.Windows.Forms.Label lblFilterName;
        private System.Windows.Forms.Button btnFilterHelp;
        private System.Windows.Forms.Button btnFilterOK;
        private System.Windows.Forms.Button btnFilterCancel;
    }
}