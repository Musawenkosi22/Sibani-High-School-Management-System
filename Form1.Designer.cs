namespace School_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SchoolName = new System.Windows.Forms.Label();
            this.AdminLogin = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ForgetPassLink = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SchoolName
            // 
            this.SchoolName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolName.AutoSize = true;
            this.SchoolName.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolName.Location = new System.Drawing.Point(382, 12);
            this.SchoolName.Name = "SchoolName";
            this.SchoolName.Size = new System.Drawing.Size(374, 35);
            this.SchoolName.TabIndex = 1;
            this.SchoolName.Text = "SIBANI HIGH SCHOOL";
            // 
            // AdminLogin
            // 
            this.AdminLogin.AutoSize = true;
            this.AdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLogin.Location = new System.Drawing.Point(459, 98);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(208, 38);
            this.AdminLogin.TabIndex = 2;
            this.AdminLogin.Text = "Admin Login";
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(400, 183);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(94, 20);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(403, 244);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(91, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameTextBox.Location = new System.Drawing.Point(511, 176);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(231, 22);
            this.usernameTextBox.TabIndex = 8;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PasswordTextBox.Location = new System.Drawing.Point(511, 244);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(231, 22);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // ForgetPassLink
            // 
            this.ForgetPassLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ForgetPassLink.AutoSize = true;
            this.ForgetPassLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgetPassLink.Location = new System.Drawing.Point(507, 310);
            this.ForgetPassLink.Name = "ForgetPassLink";
            this.ForgetPassLink.Size = new System.Drawing.Size(145, 20);
            this.ForgetPassLink.TabIndex = 10;
            this.ForgetPassLink.TabStop = true;
            this.ForgetPassLink.Text = "Forget Password?";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Blue;
            this.BtnLogin.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(423, 364);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(337, 64);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(793, 471);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.ForgetPassLink);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.SchoolName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SchoolName;
        private System.Windows.Forms.Label AdminLogin;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.LinkLabel ForgetPassLink;
        private System.Windows.Forms.Button BtnLogin;
    }
}

