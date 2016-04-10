/* Program: Message Encryption (Program.cs)
 * 
 * Authors: Peter Day, Aaron Blenkinsop & James Jassie
 * Created: 23/02/2016
 * 
 * The program takes text in either the plain text box or the encrypted text box.
 * Upon the click events Encrypt or Decrypt, the text in the corresponding box is then
 * stored as a string variable. This is looped through to create a Char List from where the text is processed
 * through a switch statement to create a second Char List before being converted back to string format to be
 * displayed in the destination rich text box.
 * The program has a number of functions to allow loading and saving from/to text files into the text boxes.
 */

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
            Application.Run(new LoginBox());
        }
    }
}
