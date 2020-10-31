namespace HoroscopWF
{
    partial class FormRegistration
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
            this.regButton = new System.Windows.Forms.Button();
            this.loginTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.DayTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MonthTb = new System.Windows.Forms.TextBox();
            this.YearTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.regButton.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.regButton.Font = new System.Drawing.Font("URWTaurusD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.regButton.Location = new System.Drawing.Point(52, 452);
            this.regButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(428, 58);
            this.regButton.TabIndex = 0;
            this.regButton.Text = "Registration";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // loginTb
            // 
            this.loginTb.Font = new System.Drawing.Font("Trajan Color", 20.25F);
            this.loginTb.Location = new System.Drawing.Point(52, 64);
            this.loginTb.Multiline = true;
            this.loginTb.Name = "loginTb";
            this.loginTb.Size = new System.Drawing.Size(428, 45);
            this.loginTb.TabIndex = 1;
            this.loginTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTb
            // 
            this.passwordTb.Font = new System.Drawing.Font("Trajan Color", 20.25F);
            this.passwordTb.Location = new System.Drawing.Point(52, 164);
            this.passwordTb.Multiline = true;
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(428, 45);
            this.passwordTb.TabIndex = 2;
            this.passwordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("URWTaurusD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(230, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("URWTaurusD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(215, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("URWTaurusD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(196, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Of Birth";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.backButton.Font = new System.Drawing.Font("URWTaurusD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.backButton.Location = new System.Drawing.Point(52, 527);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(428, 46);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // DayTb
            // 
            this.DayTb.Font = new System.Drawing.Font("URWTaurusD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayTb.Location = new System.Drawing.Point(72, 299);
            this.DayTb.Multiline = true;
            this.DayTb.Name = "DayTb";
            this.DayTb.Size = new System.Drawing.Size(66, 50);
            this.DayTb.TabIndex = 8;
            this.DayTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("URWTaurusD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(65, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 50);
            this.label4.TabIndex = 9;
            this.label4.Text = "DAY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("URWTaurusD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(407, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 50);
            this.label5.TabIndex = 11;
            this.label5.Text = "YEAR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MonthTb
            // 
            this.MonthTb.Font = new System.Drawing.Font("URWTaurusD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthTb.Location = new System.Drawing.Point(236, 299);
            this.MonthTb.Multiline = true;
            this.MonthTb.Name = "MonthTb";
            this.MonthTb.Size = new System.Drawing.Size(66, 50);
            this.MonthTb.TabIndex = 10;
            this.MonthTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // YearTb
            // 
            this.YearTb.Font = new System.Drawing.Font("URWTaurusD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTb.Location = new System.Drawing.Point(414, 299);
            this.YearTb.Multiline = true;
            this.YearTb.Name = "YearTb";
            this.YearTb.Size = new System.Drawing.Size(66, 50);
            this.YearTb.TabIndex = 12;
            this.YearTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("URWTaurusD", 26F);
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(214, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 50);
            this.label6.TabIndex = 13;
            this.label6.Text = "MONTH";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.panel1.Controls.Add(this.loginTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.regButton);
            this.panel1.Controls.Add(this.YearTb);
            this.panel1.Controls.Add(this.passwordTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MonthTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DayTb);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("URWTaurusD", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 591);
            this.panel1.TabIndex = 14;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(534, 591);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trajan Color", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox loginTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox DayTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MonthTb;
        private System.Windows.Forms.TextBox YearTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}