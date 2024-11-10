
namespace SMO20240904
{
  partial class FormSQLWKS
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
        this.btnSaveWks = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnOpenWks = new System.Windows.Forms.Button();
        this.btnListWks = new System.Windows.Forms.Button();
        this.listbox1 = new System.Windows.Forms.ListBox();
        this.txtWksName = new System.Windows.Forms.TextBox();
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
        // btnSaveWks
        // 
        this.btnSaveWks.Location = new System.Drawing.Point(278, 277);
        this.btnSaveWks.Name = "btnSaveWks";
        this.btnSaveWks.Size = new System.Drawing.Size(105, 23);
        this.btnSaveWks.TabIndex = 57;
        this.btnSaveWks.Text = "保存工作空间";
        this.btnSaveWks.UseVisualStyleBackColor = true;
        // 
        // btnCancel
        // 
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Location = new System.Drawing.Point(276, 370);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(105, 23);
        this.btnCancel.TabIndex = 56;
        this.btnCancel.Text = "取消";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
        // 
        // btnOpenWks
        // 
        this.btnOpenWks.Location = new System.Drawing.Point(276, 320);
        this.btnOpenWks.Name = "btnOpenWks";
        this.btnOpenWks.Size = new System.Drawing.Size(105, 23);
        this.btnOpenWks.TabIndex = 55;
        this.btnOpenWks.Text = "打开工作空间";
        this.btnOpenWks.UseVisualStyleBackColor = true;
        this.btnOpenWks.Click += new System.EventHandler(this.btnOpenWks_Click);
        // 
        // btnListWks
        // 
        this.btnListWks.Location = new System.Drawing.Point(276, 236);
        this.btnListWks.Name = "btnListWks";
        this.btnListWks.Size = new System.Drawing.Size(105, 23);
        this.btnListWks.TabIndex = 54;
        this.btnListWks.Text = "列出工作空间";
        this.btnListWks.UseVisualStyleBackColor = true;
        this.btnListWks.Click += new System.EventHandler(this.btnListWks_Click);
        // 
        // listbox1
        // 
        this.listbox1.FormattingEnabled = true;
        this.listbox1.ItemHeight = 12;
        this.listbox1.Location = new System.Drawing.Point(28, 236);
        this.listbox1.Name = "listbox1";
        this.listbox1.Size = new System.Drawing.Size(230, 160);
        this.listbox1.TabIndex = 53;
        // 
        // txtWksName
        // 
        this.txtWksName.Location = new System.Drawing.Point(141, 202);
        this.txtWksName.Name = "txtWksName";
        this.txtWksName.Size = new System.Drawing.Size(242, 21);
        this.txtWksName.TabIndex = 52;
        this.txtWksName.Text = "shanghai";
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(25, 206);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(77, 12);
        this.label5.TabIndex = 51;
        this.label5.Text = "工作空间名：";
        // 
        // txtPassword
        // 
        this.txtPassword.Location = new System.Drawing.Point(141, 158);
        this.txtPassword.Name = "txtPassword";
        this.txtPassword.PasswordChar = '*';
        this.txtPassword.Size = new System.Drawing.Size(242, 21);
        this.txtPassword.TabIndex = 50;
        this.txtPassword.Text = "123";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(25, 162);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(41, 12);
        this.label4.TabIndex = 49;
        this.label4.Text = "密码：";
        // 
        // txtUser
        // 
        this.txtUser.Location = new System.Drawing.Point(141, 106);
        this.txtUser.Name = "txtUser";
        this.txtUser.Size = new System.Drawing.Size(242, 21);
        this.txtUser.TabIndex = 48;
        this.txtUser.Text = "sa";
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(25, 110);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(53, 12);
        this.label3.TabIndex = 47;
        this.label3.Text = "用户名：";
        // 
        // txtDatabase
        // 
        this.txtDatabase.Location = new System.Drawing.Point(141, 57);
        this.txtDatabase.Name = "txtDatabase";
        this.txtDatabase.Size = new System.Drawing.Size(242, 21);
        this.txtDatabase.TabIndex = 46;
        this.txtDatabase.Text = "shanghai";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(25, 61);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(53, 12);
        this.label2.TabIndex = 45;
        this.label2.Text = "数据库：";
        // 
        // txtServer
        // 
        this.txtServer.Location = new System.Drawing.Point(141, 16);
        this.txtServer.Name = "txtServer";
        this.txtServer.Size = new System.Drawing.Size(242, 21);
        this.txtServer.TabIndex = 44;
        this.txtServer.Text = "GEOSCENE\\MSSQLSERVER1";
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(25, 20);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(65, 12);
        this.label1.TabIndex = 43;
        this.label1.Text = "服务器名：";
        // 
        // FormSQLWKS
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(396, 412);
        this.Controls.Add(this.btnSaveWks);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOpenWks);
        this.Controls.Add(this.btnListWks);
        this.Controls.Add(this.listbox1);
        this.Controls.Add(this.txtWksName);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.txtPassword);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.txtUser);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.txtDatabase);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtServer);
        this.Controls.Add(this.label1);
        this.Margin = new System.Windows.Forms.Padding(2);
        this.Name = "FormSQLWKS";
        this.Text = "SQL工作空间";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    public System.Windows.Forms.Button btnSaveWks;
    private System.Windows.Forms.Button btnCancel;
    public System.Windows.Forms.Button btnOpenWks;
    private System.Windows.Forms.Button btnListWks;
    private System.Windows.Forms.ListBox listbox1;
    public System.Windows.Forms.TextBox txtWksName;
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