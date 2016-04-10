using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Message_Encryption
{
    public partial class LoginBox : Form
    {
        #region Login Box Controls 1
        public LoginBox()
        {
            InitializeComponent();
        }
        #endregion

        #region New User Button
        NewUserBox programEntry = new NewUserBox();

        private void newUser_Click(object sender, EventArgs e)
        {            
            programEntry.Show();
        }
        #endregion

        #region Current User Confirmation & Main Form Open
        encryptionWindow mainProgram = new encryptionWindow();

        private void confirm_Btn_Click(object sender, EventArgs e)
        {
            string username = userNameBox.Text;
            string password = passwordBox.Text;

            if ((string.IsNullOrWhiteSpace(userNameBox.Text.Trim())) || (string.IsNullOrWhiteSpace(passwordBox.Text.Trim())))
            {
                MessageBox.Show("Please enter your username and password");
            }

            else
            {
                //Look up username in [Message_Encryption.sdf].[User] and verify password


                this.Hide();
                mainProgram.Show();
            }
        }
        #endregion

        #region Login Box Controls 2
        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Exit
        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void LoginBox_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'message_EncryptionDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.message_EncryptionDataSet.User);

        }




    }
}
