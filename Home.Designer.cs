namespace Assignment2
{
    partial class Home
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditProfile = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(377, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EditProfile
            // 
            this.EditProfile.Location = new System.Drawing.Point(407, 232);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(126, 30);
            this.EditProfile.TabIndex = 1;
            this.EditProfile.Text = "Edit Profile";
            this.EditProfile.UseVisualStyleBackColor = true;
            this.EditProfile.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(407, 268);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(126, 30);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(65, 63);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(107, 17);
            this.WelcomeLabel.TabIndex = 3;
            this.WelcomeLabel.Text = "Welcome Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 503);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}