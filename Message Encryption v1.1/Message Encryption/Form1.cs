using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Message_Encryption
{
    public partial class encryptionWindow : Form
    {

        public encryptionWindow()
        {
            InitializeComponent();
        }

        private void encryptionWindow_Load(object sender, EventArgs e)
        {

        }

        private void messageBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadTextFile_Click(object sender, EventArgs e)
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

        public void saveToText_Click(object sender, EventArgs e)
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

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadTextFile2_Click(object sender, EventArgs e)
        {
            //Set parameters of the OpenFileDialog
            OpenFileDialog encDataFile = new OpenFileDialog();
            encDataFile.Filter = "Text File (.txt)| *.txt";
            encDataFile.Multiselect = false;
            encDataFile.InitialDirectory = "c:\\";

            //Show OpenFileDialog Box
            if (encDataFile.ShowDialog() == DialogResult.OK)
                encryptedMessageBox.LoadFile(encDataFile.FileName,
                    RichTextBoxStreamType.PlainText);
        }

        private void saveToText2_Click(object sender, EventArgs e)
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

        private void encryptText_Click(object sender, EventArgs e)
        {

        }

        private void decrpytText_Click(object sender, EventArgs e)
        {

        }

        private void encryptedMessageBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
