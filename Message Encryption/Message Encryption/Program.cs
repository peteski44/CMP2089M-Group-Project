using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Message_Encryption
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
            //My code starts here.
            //Variables to store text from either text box.
            string pTxtIn = messageBox.Text;
            string eTxtIn = encryptedMessageBox.Text;

            //Create instance of Data Class
            Data textRead = new Data(pTxtIn, eTxtIn);
        }
    }
}
