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
    public partial class NewUserBox : Form
    {
        #region Initialise Form
        public NewUserBox()
        {
            InitializeComponent();
        }
        #endregion

        #region Username Input
        private void newUserName_Click(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Password Input
        private void newPassword_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Confirm Password Input
        private void confirmPasswordBox_Click(object sender, EventArgs e)
        {

        }

        private void confirmPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Click Event Controls
        private void OK_btn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password1 = passwordBox.Text;
            string password2 = confirmPasswordBox.Text;

            if (string.IsNullOrWhiteSpace(usernameBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a username");
            }

            else if (string.IsNullOrWhiteSpace(passwordBox.Text.Trim()))
            {
                MessageBox.Show("Please enter a password");
            }

            else if (string.IsNullOrWhiteSpace(confirmPasswordBox.Text.Trim()))
            {
                MessageBox.Show("Please re-enter your password");
            }
            else if (password1 != password2)
            {
                MessageBox.Show("Both passwords must be the same, please re-enter");
                passwordBox.Clear();
                confirmPasswordBox.Clear();
            }

            else
            {
                //Create entry in Message_Encryption.sdf.[User], insert username and password
                username = usernameBox.Text;
                password1 = passwordBox.Text;

                this.Hide();

                LoginBox LoginBox = new LoginBox();
                LoginBox.Show();
            }
        }



        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            this.Hide();
        }
        #endregion
    }
}
