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
            this.components = new System.ComponentModel.Container();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.Label();
            this.confirm_Btn = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.newUser = new System.Windows.Forms.Button();
            this.programExit = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.message_EncryptionDataSet = new Message_Encryption.Message_EncryptionDataSet();
            this.userTableAdapter = new Message_Encryption.Message_EncryptionDataSetTableAdapters.UserTableAdapter();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message_EncryptionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordBox
            // 
            this.passwordBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource1, "Password", true));
            this.passwordBox.Location = new System.Drawing.Point(101, 82);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(172, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // passWord
            // 
            this.passWord.AutoSize = true;
            this.passWord.Location = new System.Drawing.Point(12, 85);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(53, 13);
            this.passWord.TabIndex = 3;
            this.passWord.Text = "Password";
            // 
            // confirm_Btn
            // 
            this.confirm_Btn.BackColor = System.Drawing.SystemColors.Control;
            this.confirm_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_Btn.Location = new System.Drawing.Point(199, 139);
            this.confirm_Btn.Name = "confirm_Btn";
            this.confirm_Btn.Size = new System.Drawing.Size(73, 29);
            this.confirm_Btn.TabIndex = 3;
            this.confirm_Btn.Text = "Login";
            this.confirm_Btn.UseVisualStyleBackColor = false;
            this.confirm_Btn.Click += new System.EventHandler(this.confirm_Btn_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(12, 56);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(55, 13);
            this.userName.TabIndex = 2;
            this.userName.Text = "Username";
            // 
            // userNameBox
            // 
            this.userNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Username", true));
            this.userNameBox.Location = new System.Drawing.Point(101, 53);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(171, 20);
            this.userNameBox.TabIndex = 0;
            this.userNameBox.TextChanged += new System.EventHandler(this.userNameBox_TextChanged);
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.SystemColors.Control;
            this.newUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUser.Location = new System.Drawing.Point(101, 139);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(73, 29);
            this.newUser.TabIndex = 2;
            this.newUser.Text = "New User";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.newUser_Click);
            // 
            // programExit
            // 
            this.programExit.BackColor = System.Drawing.SystemColors.Control;
            this.programExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programExit.Location = new System.Drawing.Point(199, 188);
            this.programExit.Name = "programExit";
            this.programExit.Size = new System.Drawing.Size(73, 28);
            this.programExit.TabIndex = 4;
            this.programExit.Text = "Exit";
            this.programExit.UseVisualStyleBackColor = false;
            this.programExit.Click += new System.EventHandler(this.programExit_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.message_EncryptionDataSet;
            // 
            // message_EncryptionDataSet
            // 
            this.message_EncryptionDataSet.DataSetName = "Message_EncryptionDataSet";
            this.message_EncryptionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.message_EncryptionDataSet;
            // 
            // LoginBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(306, 262);
            this.Controls.Add(this.programExit);
            this.Controls.Add(this.newUser);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.confirm_Btn);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.passwordBox);
            this.Name = "LoginBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message_EncryptionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passWord;
        private System.Windows.Forms.Button confirm_Btn;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.Button newUser;
        private System.Windows.Forms.Button programExit;
        private Message_EncryptionDataSet message_EncryptionDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Message_EncryptionDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource1;
    }
}