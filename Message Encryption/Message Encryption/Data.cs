using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.ComponentModel;
using System.Drawing;

namespace Message_Encryption
{
    class Data
    {
        //Method for importing text to plain text box(messageBox).
        private void loadPText()
        {
            //Set parameters of the OpenFileDialog
            OpenFileDialog dataFile = new OpenFileDialog();
            dataFile.Filter = "Text Files (.txt)| *.txt";
            dataFile.Multiselect = false;
            dataFile.InitialDirectory = "c:\\";

            //Show OpenFileDialog Box
            if (dataFile.ShowDialog() == DialogResult.OK)
                messageBox.LoadFile(dataFile.FileName,
                    RichTextBoxStreamType.PlainText);
        }

        //Method for saving text to file from plain text box(messageBox).
        private void savePText()
        {
            //Set parameters for SaveFileDialog
            SaveFileDialog toTextFile = new SaveFileDialog();
            toTextFile.DefaultExt = "*.txt";
            toTextFile.Filter = "Text Files|*.txt";

            //Show SaveFileDialog Box
            if (toTextFile.ShowDialog() == DialogResult.OK && toTextFile.FileName.Length > 0)
            {
                messageBox.SaveFile(toTextFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        //Method for importing text to encrypted text box(encryptedMessageBox)
        private void loadETxt()
        {
            //Set parameters of the OpenFileDialog
            OpenFileDialog encDataFile = new OpenFileDialog();
            encDataFile.Filter = "Text File (.txt)| *.txt";
            encDataFile.Multiselect = false;
            encDataFile.InitialDirectory = "c:\\";

            //Show OpenFileDialog Box
            if (encDataFile.ShowDialog == DialogResult.OK)
                encryptedMessageBox.LoadFile(encDataFile.FileName, 
                    RichTextBoxStreamType.PlainText);
        }

        //Method for saving text to file from encrypted text box(encryptedMessageBox)
        private void saveETxt()
        {
            //Set parameters for SaveFileDialog
            SaveFileDialog encToTextFile = new SaveFileDialog();
            encToTextFile.DefaultExt = "*.txt";
            encToTextFile.Filter = "Text Files|*.txt";

            //Show SaveFileDialog Box
            if (encToTextFile.ShowDialog() == DialogResult.OK && encToTextFile.FileName.Length > 0)
            {
                encryptedMessageBox.SaveFile(encToTextFile.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        //Method for populating array from plain text box(messageBox)
        //and encrypting text within the array to output into the
        //encrypted text box(encryptedMessageBox)
        private string encrypt(string pTxtIn)
        {
            
        }
         
    }
}
