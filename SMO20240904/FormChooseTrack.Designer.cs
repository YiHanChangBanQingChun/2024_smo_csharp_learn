namespace SMO20240904
{
    partial class FormChooseTrack
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
            this.cboStart = new System.Windows.Forms.ComboBox();
            this.cboEnd = new System.Windows.Forms.ComboBox();
            this.cboStartLayer = new System.Windows.Forms.ComboBox();
            this.cboEndLayer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChooseTrack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboStart
            // 
            this.cboStart.FormattingEnabled = true;
            this.cboStart.Location = new System.Drawing.Point(270, 73);
            this.cboStart.Name = "cboStart";
            this.cboStart.Size = new System.Drawing.Size(121, 20);
            this.cboStart.TabIndex = 0;
            this.cboStart.SelectedIndexChanged += new System.EventHandler(this.cboStart_SelectedIndexChanged);
            // 
            // cboEnd
            // 
            this.cboEnd.FormattingEnabled = true;
            this.cboEnd.Location = new System.Drawing.Point(270, 132);
            this.cboEnd.Name = "cboEnd";
            this.cboEnd.Size = new System.Drawing.Size(121, 20);
            this.cboEnd.TabIndex = 1;
            this.cboEnd.SelectedIndexChanged += new System.EventHandler(this.cboEnd_SelectedIndexChanged);
            // 
            // cboStartLayer
            // 
            this.cboStartLayer.FormattingEnabled = true;
            this.cboStartLayer.Location = new System.Drawing.Point(72, 73);
            this.cboStartLayer.Name = "cboStartLayer";
            this.cboStartLayer.Size = new System.Drawing.Size(121, 20);
            this.cboStartLayer.TabIndex = 2;
            this.cboStartLayer.SelectedIndexChanged += new System.EventHandler(this.cboStartLayer_SelectedIndexChanged);
            // 
            // cboEndLayer
            // 
            this.cboEndLayer.FormattingEnabled = true;
            this.cboEndLayer.Location = new System.Drawing.Point(72, 132);
            this.cboEndLayer.Name = "cboEndLayer";
            this.cboEndLayer.Size = new System.Drawing.Size(121, 20);
            this.cboEndLayer.TabIndex = 3;
            this.cboEndLayer.SelectedIndexChanged += new System.EventHandler(this.cboEndLayer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "选择图层与目标点以生成直线跟踪";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "起点图层";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "终点图层";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "起点";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "终点";
            // 
            // btnChooseTrack
            // 
            this.btnChooseTrack.Location = new System.Drawing.Point(174, 195);
            this.btnChooseTrack.Name = "btnChooseTrack";
            this.btnChooseTrack.Size = new System.Drawing.Size(75, 23);
            this.btnChooseTrack.TabIndex = 9;
            this.btnChooseTrack.Text = "确定";
            this.btnChooseTrack.UseVisualStyleBackColor = true;
            this.btnChooseTrack.Click += new System.EventHandler(this.btnChooseTrack_Click);
            // 
            // FormChooseTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 230);
            this.Controls.Add(this.btnChooseTrack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEndLayer);
            this.Controls.Add(this.cboStartLayer);
            this.Controls.Add(this.cboEnd);
            this.Controls.Add(this.cboStart);
            this.Name = "FormChooseTrack";
            this.Text = "FormChooseTrack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStart;
        private System.Windows.Forms.ComboBox cboEnd;
        private System.Windows.Forms.ComboBox cboStartLayer;
        private System.Windows.Forms.ComboBox cboEndLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChooseTrack;
    }
}