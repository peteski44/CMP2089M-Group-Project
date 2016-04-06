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

        #region Current Uer Confirmation & Main Form Open
        encryptionWindow mainProgram = new encryptionWindow();

        private void confirmLogin_Click(object sender, EventArgs e)
        {
            String username = userNameBox.Text;
            String password = passwordBox.Text;

            if ((String.IsNullOrWhiteSpace(userNameBox.Text.Trim())) || (String.IsNullOrWhiteSpace(passwordBox.Text.Trim())))
            {
                MessageBox.Show("Please enter your username and password");
            }

            else
            {
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




    }
}
