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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.newUserName = new System.Windows.Forms.Label();
            this.newPassWord = new System.Windows.Forms.Label();
            this.reconfirmPassWord = new System.Windows.Forms.Label();
            this.loGin = new System.Windows.Forms.Button();
            this.stopLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(131, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // newUserName
            // 
            this.newUserName.AutoSize = true;
            this.newUserName.Location = new System.Drawing.Point(12, 49);
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
            this.newPassWord.Click += new System.EventHandler(this.newPassWord_Click);
            // 
            // reconfirmPassWord
            // 
            this.reconfirmPassWord.AutoSize = true;
            this.reconfirmPassWord.Location = new System.Drawing.Point(12, 116);
            this.reconfirmPassWord.Name = "reconfirmPassWord";
            this.reconfirmPassWord.Size = new System.Drawing.Size(90, 13);
            this.reconfirmPassWord.TabIndex = 5;
            this.reconfirmPassWord.Text = "Retype Password";
            this.reconfirmPassWord.Click += new System.EventHandler(this.reconfirmPassWord_Click);
            // 
            // loGin
            // 
            this.loGin.Location = new System.Drawing.Point(131, 154);
            this.loGin.Name = "loGin";
            this.loGin.Size = new System.Drawing.Size(75, 23);
            this.loGin.TabIndex = 6;
            this.loGin.Text = "Login";
            this.loGin.UseVisualStyleBackColor = true;
            this.loGin.Click += new System.EventHandler(this.loGin_Click);
            // 
            // stopLogin
            // 
            this.stopLogin.Location = new System.Drawing.Point(131, 183);
            this.stopLogin.Name = "stopLogin";
            this.stopLogin.Size = new System.Drawing.Size(75, 23);
            this.stopLogin.TabIndex = 7;
            this.stopLogin.Text = "Cancel";
            this.stopLogin.UseVisualStyleBackColor = true;
            this.stopLogin.Click += new System.EventHandler(this.stopLogin_Click);
            // 
            // NewUserBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.stopLogin);
            this.Controls.Add(this.loGin);
            this.Controls.Add(this.reconfirmPassWord);
            this.Controls.Add(this.newPassWord);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NewUserBox";
            this.Text = "NewUserBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label newUserName;
        private System.Windows.Forms.Label newPassWord;
        private System.Windows.Forms.Label reconfirmPassWord;
        private System.Windows.Forms.Button loGin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button stopLogin;
    }
}