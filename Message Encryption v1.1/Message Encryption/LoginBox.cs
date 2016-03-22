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
        public LoginBox()
        {
            InitializeComponent();
        }

        NewUserBox programEntry = new NewUserBox();

        private void newUser_Click(object sender, EventArgs e)
        {
            programEntry.Show();
        }

        encryptionWindow mainProgram = new encryptionWindow();

        private void confirmLogin_Click(object sender, EventArgs e)
        {
            mainProgram.Show();  
        }

        

        private void passWordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void programExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
