namespace HoroscopWF
{
    partial class FormProphecy
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
            this.prophecyPanel = new System.Windows.Forms.Panel();
            this.endBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.prophecyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prophecyPanel
            // 
            this.prophecyPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.prophecyPanel.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.prophecyPanel.Controls.Add(this.endBtn);
            this.prophecyPanel.Controls.Add(this.textBox1);
            this.prophecyPanel.Controls.Add(this.pictureBox1);
            this.prophecyPanel.Location = new System.Drawing.Point(2, -2);
            this.prophecyPanel.Name = "prophecyPanel";
            this.prophecyPanel.Size = new System.Drawing.Size(966, 726);
            this.prophecyPanel.TabIndex = 0;
            // 
            // endBtn
            // 
            this.endBtn.AllowDrop = true;
            this.endBtn.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.endBtn.Font = new System.Drawing.Font("URWTaurusD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endBtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.endBtn.Location = new System.Drawing.Point(391, 677);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(180, 35);
            this.endBtn.TabIndex = 2;
            this.endBtn.Text = "End";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("URWTaurusD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.textBox1.Location = new System.Drawing.Point(49, 200);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(871, 454);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "sdxcfv";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HoroscopWF.Properties.Resources._161;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(391, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormProphecy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(968, 722);
            this.Controls.Add(this.prophecyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProphecy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProphecyForm";
            this.prophecyPanel.ResumeLayout(false);
            this.prophecyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel prophecyPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button endBtn;
    }
}