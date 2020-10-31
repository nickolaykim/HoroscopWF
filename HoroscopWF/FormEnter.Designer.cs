namespace HoroscopWF
{
    partial class FormEnter
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterLogo = new System.Windows.Forms.PictureBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.panel1.Controls.Add(this.enterLogo);
            this.panel1.Controls.Add(this.regBtn);
            this.panel1.Controls.Add(this.loginTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passwordTb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 595);
            this.panel1.TabIndex = 21;
            // 
            // enterLogo
            // 
            this.enterLogo.BackgroundImage = global::HoroscopWF.Properties.Resources._161;
            this.enterLogo.Image = global::HoroscopWF.Properties.Resources._161;
            this.enterLogo.Location = new System.Drawing.Point(173, 3);
            this.enterLogo.Name = "enterLogo";
            this.enterLogo.Size = new System.Drawing.Size(180, 180);
            this.enterLogo.TabIndex = 21;
            this.enterLogo.TabStop = false;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regBtn.Font = new System.Drawing.Font("URWTaurusD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.Goldenrod;
            this.regBtn.Location = new System.Drawing.Point(51, 498);
            this.regBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(428, 46);
            this.regBtn.TabIndex = 20;
            this.regBtn.Text = "REGISTRATION";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // loginTb
            // 
            this.loginTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTb.Font = new System.Drawing.Font("URWTaurusD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTb.ForeColor = System.Drawing.Color.Black;
            this.loginTb.Location = new System.Drawing.Point(51, 229);
            this.loginTb.Multiline = true;
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(428, 45);
            this.loginTb.TabIndex = 15;
            this.loginTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("URWTaurusD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(212, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterButton.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.enterButton.Font = new System.Drawing.Font("URWTaurusD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.enterButton.Location = new System.Drawing.Point(51, 422);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(428, 58);
            this.enterButton.TabIndex = 14;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("URWTaurusD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(228, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Login";
            // 
            // passwordTb
            // 
            this.passwordTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTb.Font = new System.Drawing.Font("URWTaurusD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTb.ForeColor = System.Drawing.Color.Black;
            this.passwordTb.Location = new System.Drawing.Point(51, 329);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(428, 45);
            this.passwordTb.TabIndex = 16;
            this.passwordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enterLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox enterLogo;
    }
}