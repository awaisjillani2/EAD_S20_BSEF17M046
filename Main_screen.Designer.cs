namespace Assignment2
{
    partial class MainScreen
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
            this.NewUser = new System.Windows.Forms.Button();
            this.ExistingUser = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(168, 83);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(122, 45);
            this.NewUser.TabIndex = 0;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // ExistingUser
            // 
            this.ExistingUser.Location = new System.Drawing.Point(168, 150);
            this.ExistingUser.Name = "ExistingUser";
            this.ExistingUser.Size = new System.Drawing.Size(122, 45);
            this.ExistingUser.TabIndex = 1;
            this.ExistingUser.Text = "Existing User";
            this.ExistingUser.UseVisualStyleBackColor = true;
            this.ExistingUser.Click += new System.EventHandler(this.ExistingUser_Click);
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(168, 227);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(122, 45);
            this.Admin.TabIndex = 2;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(168, 299);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 45);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(476, 487);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.ExistingUser);
            this.Controls.Add(this.NewUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button ExistingUser;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Button Exit;
    }
}

