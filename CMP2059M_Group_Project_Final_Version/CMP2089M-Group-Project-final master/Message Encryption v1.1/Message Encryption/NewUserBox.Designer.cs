namespace Message_Encryption
{
    partial class NewUserBox
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.newUserName = new System.Windows.Forms.Label();
            this.newPassWord = new System.Windows.Forms.Label();
            this.confirmPassWord = new System.Windows.Forms.Label();
            this.OK_btn = new System.Windows.Forms.Button();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(116, 49);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(156, 20);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(116, 84);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(156, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(116, 116);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(156, 20);
            this.confirmPasswordBox.TabIndex = 2;
            // 
            // newUserName
            // 
            this.newUserName.AutoSize = true;
            this.newUserName.Location = new System.Drawing.Point(13, 52);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(89, 13);
            this.newUserName.TabIndex = 3;
            this.newUserName.Text = "Create Username";
            this.newUserName.Click += new System.EventHandler(this.newUserName_Click);
            // 
            // newPassWord
            // 
            this.newPassWord.AutoSize = true;
            this.newPassWord.Location = new System.Drawing.Point(12, 87);
            this.newPassWord.Name = "newPassWord";
            this.newPassWord.Size = new System.Drawing.Size(87, 13);
            this.newPassWord.TabIndex = 4;
            this.newPassWord.Text = "Create Password";
            // 
            // confirmPassWord
            // 
            this.confirmPassWord.AutoSize = true;
            this.confirmPassWord.Location = new System.Drawing.Point(12, 119);
            this.confirmPassWord.Name = "confirmPassWord";
            this.confirmPassWord.Size = new System.Drawing.Size(91, 13);
            this.confirmPassWord.TabIndex = 5;
            this.confirmPassWord.Text = "Confirm Password";
            this.confirmPassWord.Click += new System.EventHandler(this.confirmPasswordBox_Click);
            // 
            // OK_btn
            // 
            this.OK_btn.BackColor = System.Drawing.SystemColors.Control;
            this.OK_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_btn.Location = new System.Drawing.Point(197, 154);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 29);
            this.OK_btn.TabIndex = 4;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = false;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_Btn.Location = new System.Drawing.Point(116, 154);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(75, 29);
            this.cancel_Btn.TabIndex = 3;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = false;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // NewUserBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(306, 262);
            this.Controls.Add(this.cancel_Btn);
            this.Controls.Add(this.OK_btn);
            this.Controls.Add(this.confirmPassWord);
            this.Controls.Add(this.newPassWord);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Name = "NewUserBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label newUserName;
        private System.Windows.Forms.Label newPassWord;
        private System.Windows.Forms.Label confirmPassWord;
        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Button cancel_Btn;
    }
}