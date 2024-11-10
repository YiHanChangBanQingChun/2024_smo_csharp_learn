
namespace SMO20240904
{
    partial class FormCreateDst
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
            this.label3 = new System.Windows.Forms.Label();
            this.cboDstType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtDstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDatasource = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "数据集类型：";
            // 
            // cboDstType
            // 
            this.cboDstType.FormattingEnabled = true;
            this.cboDstType.Items.AddRange(new object[] {
            "点",
            "线",
            "面"});
            this.cboDstType.Location = new System.Drawing.Point(110, 98);
            this.cboDstType.Name = "cboDstType";
            this.cboDstType.Size = new System.Drawing.Size(157, 20);
            this.cboDstType.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(192, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(110, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDstName
            // 
            this.txtDstName.Location = new System.Drawing.Point(110, 23);
            this.txtDstName.Name = "txtDstName";
            this.txtDstName.Size = new System.Drawing.Size(157, 21);
            this.txtDstName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "目标数据源：";
            // 
            // cboDatasource
            // 
            this.cboDatasource.FormattingEnabled = true;
            this.cboDatasource.Location = new System.Drawing.Point(110, 59);
            this.cboDatasource.Name = "cboDatasource";
            this.cboDatasource.Size = new System.Drawing.Size(157, 20);
            this.cboDatasource.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "数据集名称：";
            // 
            // FormCreateDst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 196);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDstType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboDatasource);
            this.Controls.Add(this.label1);
            this.Name = "FormCreateDst";
            this.Text = "FormCreateDst";
            this.Load += new System.EventHandler(this.FormCreateDst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDstType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtDstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDatasource;
        private System.Windows.Forms.Label label1;
    }
}