namespace SMO20240904
{
    partial class FormOverlayAnalyse
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
            this.cboBeOverlay = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOverlayRegion = new System.Windows.Forms.ComboBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOverlayCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboBeOverlay
            // 
            this.cboBeOverlay.FormattingEnabled = true;
            this.cboBeOverlay.Location = new System.Drawing.Point(94, 81);
            this.cboBeOverlay.Name = "cboBeOverlay";
            this.cboBeOverlay.Size = new System.Drawing.Size(121, 20);
            this.cboBeOverlay.TabIndex = 3;
            this.cboBeOverlay.SelectedIndexChanged += new System.EventHandler(this.cboBeOverlay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "被叠置图层";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "选择被叠置图层与叠置面";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "叠置面";
            // 
            // cboOverlayRegion
            // 
            this.cboOverlayRegion.FormattingEnabled = true;
            this.cboOverlayRegion.Location = new System.Drawing.Point(298, 81);
            this.cboOverlayRegion.Name = "cboOverlayRegion";
            this.cboOverlayRegion.Size = new System.Drawing.Size(121, 20);
            this.cboOverlayRegion.TabIndex = 9;
            this.cboOverlayRegion.SelectedIndexChanged += new System.EventHandler(this.cboOverlayRegion_SelectedIndexChanged);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(110, 175);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 10;
            this.btnCut.Text = "裁剪";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(276, 175);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "擦除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "叠置区";
            // 
            // cboOverlayCity
            // 
            this.cboOverlayCity.FormattingEnabled = true;
            this.cboOverlayCity.Location = new System.Drawing.Point(298, 128);
            this.cboOverlayCity.Name = "cboOverlayCity";
            this.cboOverlayCity.Size = new System.Drawing.Size(121, 20);
            this.cboOverlayCity.TabIndex = 13;
            this.cboOverlayCity.SelectedIndexChanged += new System.EventHandler(this.cboOverlayCity_SelectedIndexChanged);
            // 
            // FormOverlayAnalyse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 210);
            this.Controls.Add(this.cboOverlayCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.cboOverlayRegion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBeOverlay);
            this.Name = "FormOverlayAnalyse";
            this.Text = "FormOverlayAnalyse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBeOverlay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOverlayRegion;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOverlayCity;
    }
}