namespace SMO20240904
{
    partial class Form3DPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3DPath));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SuperMapFly = new AxSuperMapLib.AxSuperMap();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuperMapFly)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SuperMapFly);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(1168, 971);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // SuperMapFly
            // 
            this.SuperMapFly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SuperMapFly.Enabled = true;
            this.SuperMapFly.Location = new System.Drawing.Point(0, 0);
            this.SuperMapFly.Name = "SuperMapFly";
            this.SuperMapFly.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SuperMapFly.OcxState")));
            this.SuperMapFly.Size = new System.Drawing.Size(883, 971);
            this.SuperMapFly.TabIndex = 1;
            // 
            // Form3DPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 971);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3DPath";
            this.Text = "Form3DPath";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SuperMapFly)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AxSuperMapLib.AxSuperMap SuperMapFly;

    }
}