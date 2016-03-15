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
            //Set the parameters of the Open File Dialog
            OpenFileDialog dataFile = new OpenFileDialog();
            dataFile.Filter = "Text Files (.txt)| *.txt";
            dataFile.Multiselect = false;
            dataFile.InitialDirectory = "c:\\";

            //Show the Open File Dialog Box
            if (dataFile.ShowDialog() == DialogResult.OK)
                messageBox.LoadFile(dataFile.FileName,
                    RichTextBoxStreamType.PlainText);
        }

        public void saveToText_Click(object sender, EventArgs e)
        {
            //Set parameters for Save File Dialog
            SaveFileDialog fileSave = new SaveFileDialog();
            fileSave.DefaultExt = "*.txt";
            fileSave.Filter = "Text Files|*.txt";

            //Show the Save File Dialog Box
            if (fileSave.ShowDialog() == DialogResult.OK && fileSave.FileName.Length > 0)
            {
                messageBox.SaveFile(fileSave.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadTextFile2_Click(object sender, EventArgs e)
        {

        }

        private void saveToText2_Click(object sender, EventArgs e)
        {

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
