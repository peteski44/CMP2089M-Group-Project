namespace Message_Encryption
{
    partial class LoginBox
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
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.Label();
            this.confirmLogin = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.newUser = new System.Windows.Forms.Button();
            this.programExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(100, 85);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(172, 20);
            this.passwordBox.TabIndex = 0;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passWord
            // 
            this.passWord.AutoSize = true;
            this.passWord.Location = new System.Drawing.Point(12, 85);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(81, 13);
            this.passWord.TabIndex = 1;
            this.passWord.Text = "Enter Password";
            // 
            // confirmLogin
            // 
            this.confirmLogin.Location = new System.Drawing.Point(199, 139);
            this.confirmLogin.Name = "confirmLogin";
            this.confirmLogin.Size = new System.Drawing.Size(73, 29);
            this.confirmLogin.TabIndex = 2;
            this.confirmLogin.Text = "Confirm";
            this.confirmLogin.UseVisualStyleBackColor = true;
            this.confirmLogin.Click += new System.EventHandler(this.confirmLogin_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(12, 60);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(83, 13);
            this.userName.TabIndex = 3;
            this.userName.Text = "Enter Username";
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(101, 60);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(171, 20);
            this.userNameBox.TabIndex = 4;
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // newUser
            // 
            this.newUser.Location = new System.Drawing.Point(101, 139);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(73, 29);
            this.newUser.TabIndex = 5;
            this.newUser.Text = "New User";
            this.newUser.UseVisualStyleBackColor = true;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // programExit
            // 
            this.programExit.Location = new System.Drawing.Point(199, 188);
            this.programExit.Name = "programExit";
            this.programExit.Size = new System.Drawing.Size(73, 28);
            this.programExit.TabIndex = 6;
            this.programExit.Text = "Exit";
            this.programExit.UseVisualStyleBackColor = true;
            this.programExit.Click += new System.EventHandler(this.programExit_Click);
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 262);
            this.Controls.Add(this.programExit);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.confirmLogin);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.passwordBox);
            this.Name = "LoginBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passWord;
        private System.Windows.Forms.Button confirmLogin;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button programExit;
    }
}