/* Program: Message Encryption (Program.cs)
 * 
 * Authors: Peter Day, Aaron Blenkinsop & James Jassie
 * Created: 23/02/2016
 * 
 * The program takes text in either the plain text box or the encrypted text box.
 * Upon the click events Encrypt or Decrypt, the text in the corresponding box is then
 * cast into a string variable. Moved in to a Char Array where the text is processed
 * and run through a switch/case statement. Upon completion the output text is placed
 * in another Char Array before being moved back to string format and displayed in the
 * empty box.
 * The program has a number of functions to allow loading and saving to text file into
 * the text boxes.
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
