namespace HoroscopWF.Pages
{
    partial class TopPlayersPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPlayersPanel = new System.Windows.Forms.Panel();
            this.topPlayersLabel = new System.Windows.Forms.Label();
            this.topLogo = new System.Windows.Forms.PictureBox();
            this.topPlayersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPlayersPanel
            // 
            this.topPlayersPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.topPlayersPanel.BackgroundImage = global::HoroscopWF.Properties.Resources._192;
            this.topPlayersPanel.Controls.Add(this.topLogo);
            this.topPlayersPanel.Controls.Add(this.topPlayersLabel);
            this.topPlayersPanel.Location = new System.Drawing.Point(0, 0);
            this.topPlayersPanel.Name = "topPlayersPanel";
            this.topPlayersPanel.Size = new System.Drawing.Size(984, 737);
            this.topPlayersPanel.TabIndex = 0;
            // 
            // topPlayersLabel
            // 
            this.topPlayersLabel.Enabled = false;
            this.topPlayersLabel.Font = new System.Drawing.Font("URWTaurusD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPlayersLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.topPlayersLabel.Location = new System.Drawing.Point(105, 231);
            this.topPlayersLabel.Name = "topPlayersLabel";
            this.topPlayersLabel.Size = new System.Drawing.Size(752, 438);
            this.topPlayersLabel.TabIndex = 0;
            this.topPlayersLabel.Text = "adsfgasdfg";
            this.topPlayersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topLogo
            // 

            this.topLogo.Location = new System.Drawing.Point(387, 12);
            this.topLogo.Name = "topLogo";
            this.topLogo.Size = new System.Drawing.Size(180, 180);
            this.topLogo.TabIndex = 22;
            this.topLogo.TabStop = false;
            // 
            // TopPlayersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.topPlayersPanel);
            this.Name = "TopPlayersPage";
            this.Size = new System.Drawing.Size(984, 737);
            this.topPlayersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPlayersPanel;
        private System.Windows.Forms.Label topPlayersLabel;
        private System.Windows.Forms.PictureBox topLogo;
    }
}
