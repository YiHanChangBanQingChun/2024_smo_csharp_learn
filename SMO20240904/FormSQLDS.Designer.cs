
namespace SMO20240904
{
    partial class FormSQLDS
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
            this.btnSaveDS = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenDS = new System.Windows.Forms.Button();
            this.txtDSName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveDS
            // 
            this.btnSaveDS.Location = new System.Drawing.Point(32, 203);
            this.btnSaveDS.Name = "btnSaveDS";
            this.btnSaveDS.Size = new System.Drawing.Size(105, 23);
            this.btnSaveDS.TabIndex = 70;
            this.btnSaveDS.Text = "保存";
            this.btnSaveDS.UseVisualStyleBackColor = true;
            this.btnSaveDS.Click += new System.EventHandler(this.btnSaveDS_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(259, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 69;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOpenDS
            // 
            this.btnOpenDS.Location = new System.Drawing.Point(143, 203);
            this.btnOpenDS.Name = "btnOpenDS";
            this.btnOpenDS.Size = new System.Drawing.Size(105, 23);
            this.btnOpenDS.TabIndex = 68;
            this.btnOpenDS.Text = "打开";
            this.btnOpenDS.UseVisualStyleBackColor = true;
            this.btnOpenDS.Click += new System.EventHandler(this.btnOpenDS_Click);
            // 
            // txtDSName
            // 
            this.txtDSName.Location = new System.Drawing.Point(121, 155);
            this.txtDSName.Name = "txtDSName";
            this.txtDSName.Size = new System.Drawing.Size(242, 21);
            this.txtDSName.TabIndex = 67;
            this.txtDSName.Text = "test2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "数据源别名：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(121, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(242, 21);
            this.txtPassword.TabIndex = 65;
            this.txtPassword.Text = "123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 64;
            this.label4.Text = "密码：";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(121, 83);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(242, 21);
            this.txtUser.TabIndex = 63;
            this.txtUser.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 62;
            this.label3.Text = "用户名：";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(121, 46);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(242, 21);
            this.txtDatabase.TabIndex = 61;
            this.txtDatabase.Text = "test2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "数据库：";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(121, 15);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(242, 21);
            this.txtServer.TabIndex = 59;
            this.txtServer.Text = "tea02\\SQLEXPRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 58;
            this.label1.Text = "服务器名：";
            // 
            // FormSQLDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 252);
            this.Controls.Add(this.btnSaveDS);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOpenDS);
            this.Controls.Add(this.txtDSName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.label1);
            this.Name = "FormSQLDS";
            this.Text = "FormSQLDS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnSaveDS;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnOpenDS;
        public System.Windows.Forms.TextBox txtDSName;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
    }
}