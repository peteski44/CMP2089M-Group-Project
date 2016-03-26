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
            //Array plainArray = messageBox.Text.ToArray();
            //encryptedMessageBox.Clear();
            //foreach (char myChar in plainArray)
            //{
            //    encryptedMessageBox.AppendText(myChar.ToString());
            //}
            //Clear the Encrypted Text Box
            encryptedMessageBox.Clear();

            //Move text from message box to string
            string pTxt = messageBox.Text.ToLower();

            List<char> pTxtList = new List<char>();

            foreach (char c in pTxt)
            {
                pTxtList.Add(c);
            }

            List<char> eTxtList = new List<char>();

            for (int i = 0; i < pTxtList.Count; i++)
            {
                switch (pTxtList[i])
                {
                    case 'a':
                        pTxtList[i] = '?';
                        break;

                    case 'b':
                        pTxtList[i] = 'd';
                        break;

                    case 'c':
                        pTxtList[i] = '4';
                        break;

                    case 'd':
                        pTxtList[i] = '-';
                        break;

                    case 'e':
                        pTxtList[i] = 'i';
                        break;

                    case 'f':
                        pTxtList[i] = '2';
                        break;

                    case 'g':
                        pTxtList[i] = 'k';
                        break;

                    case 'h':
                        pTxtList[i] = ',';
                        break;

                    case 'i':
                        pTxtList[i] = 'o';
                        break;

                    case 'j':
                        pTxtList[i] = 's';
                        break;

                    case 'k':
                        pTxtList[i] = 'u';
                        break;

                    case 'l':
                        pTxtList[i] = 'w';
                        break;

                    case 'm':
                        pTxtList[i] = '8';
                        break;

                    case 'n':
                        pTxtList[i] = 'z';
                        break;

                    case 'o':
                        pTxtList[i] = 'c';
                        break;

                    case 'p':
                        pTxtList[i] = 'a';
                        break;

                    case 'q':
                        pTxtList[i] = 'b';
                        break;

                    case 'r':
                        pTxtList[i] = 'g';
                        break;

                    case 's':
                        pTxtList[i] = '!';
                        break;

                    case 't':
                        pTxtList[i] = 'l';
                        break;

                    case 'u':
                        pTxtList[i] = 'y';
                        break;

                    case 'v':
                        pTxtList[i] = 'f';
                        break;

                    case 'w':
                        pTxtList[i] = 'h';
                        break;

                    case 'x':
                        pTxtList[i] = ' ';
                        break;

                    case 'y':
                        pTxtList[i] = 'n';
                        break;

                    case 'z':
                        pTxtList[i] = 'p';
                        break;

                    case ' ':
                        pTxtList[i] = 'm';
                        break;

                    case ',':
                        pTxtList[i] = 'q';
                        break;

                    case '-':
                        pTxtList[i] = 'r';
                        break;

                    case '?':
                        pTxtList[i] = 'v';
                        break;

                    case '!':
                        pTxtList[i] = 't';
                        break;

                    case '.':
                        pTxtList[i] = '.';
                        break;

                    case '@':
                        pTxtList[i] = '7';
                        break;

                    case '0':
                        pTxtList[i] = '&';
                        break;

                    case '1':
                        pTxtList[i] = '^';
                        break;

                    case '2':
                        pTxtList[i] = '6';
                        break;

                    case '3':
                        pTxtList[i] = '1';
                        break;

                    case '4':
                        pTxtList[i] = 'j';
                        break;

                    case '5':
                        pTxtList[i] = '9';
                        break;

                    case '6':
                        pTxtList[i] = '3';
                        break;

                    case '7':
                        pTxtList[i] = 'x';
                        break;

                    case '8':
                        pTxtList[i] = '5';
                        break;

                    case '9':
                        pTxtList[i] = 'e';
                        break;
                }
                eTxtList.Add(pTxtList[i]);

            }

            string eTxt = string.Join("", eTxtList.ToArray());
            encryptedMessageBox.Text = eTxt;
        }

        private void decryptText_Click(object sender, EventArgs e)
        {
            messageBox.Clear();

            string eTxt = encryptedMessageBox.Text.ToLower();

            List<char> eTxtList = new List<char>();

            foreach (char c in eTxt)
            {
                eTxtList.Add(c);
            }

            List<char> pTxtList = new List<char>();

            for (int i = 0; i < eTxtList.Count; i++)
            {
                switch (eTxtList[i])
                {
                    case '?':
                        eTxtList[i] = 'a';
                        break;

                    case 'd':
                        eTxtList[i] = 'b';
                        break;

                    case '4':
                        eTxtList[i] = 'c';
                        break;

                    case '-':
                        eTxtList[i] = 'd';
                        break;

                    case 'i':
                        eTxtList[i] = 'e';
                        break;

                    case '2':
                        eTxtList[i] = 'f';
                        break;

                    case 'k':
                        eTxtList[i] = 'g';
                        break;

                    case ',':
                        eTxtList[i] = 'h';
                        break;

                    case 'o':
                        eTxtList[i] = 'i';
                        break;

                    case 's':
                        eTxtList[i] = 'j';
                        break;

                    case 'u':
                        eTxtList[i] = 'k';
                        break;

                    case 'w':
                        eTxtList[i] = 'l';
                        break;

                    case '8':
                        eTxtList[i] = 'm';
                        break;

                    case 'z':
                        eTxtList[i] = 'n';
                        break;

                    case 'c':
                        eTxtList[i] = 'o';
                        break;

                    case 'a':
                        eTxtList[i] = 'p';
                        break;

                    case 'b':
                        eTxtList[i] = 'q';
                        break;

                    case 'g':
                        eTxtList[i] = 'r';
                        break;

                    case '!':
                        eTxtList[i] = 's';
                        break;

                    case 'l':
                        eTxtList[i] = 't';
                        break;

                    case 'y':
                        eTxtList[i] = 'u';
                        break;

                    case 'f':
                        eTxtList[i] = 'v';
                        break;

                    case 'h':
                        eTxtList[i] = 'w';
                        break;

                    case ' ':
                        eTxtList[i] = 'x';
                        break;

                    case 'n':
                        eTxtList[i] = 'y';
                        break;

                    case 'p':
                        eTxtList[i] = 'z';
                        break;

                    case 'm':
                        eTxtList[i] = ' ';
                        break;

                    case 'q':
                        eTxtList[i] = ',';
                        break;

                    case 'r':
                        eTxtList[i] = '-';
                        break;

                    case 'v':
                        eTxtList[i] = '?';
                        break;

                    case 't':
                        eTxtList[i] = '!';
                        break;

                    case '.':
                        eTxtList[i] = '.';
                        break;

                    case '7':
                        eTxtList[i] = '@';
                        break;

                    case '&':
                        eTxtList[i] = '0';
                        break;

                    case '^':
                        eTxtList[i] = '1';
                        break;

                    case '6':
                        eTxtList[i] = '2';
                        break;

                    case '1':
                        eTxtList[i] = '3';
                        break;

                    case 'j':
                        eTxtList[i] = '4';
                        break;

                    case '9':
                        eTxtList[i] = '5';
                        break;

                    case '3':
                        eTxtList[i] = '6';
                        break;

                    case 'x':
                        eTxtList[i] = '7';
                        break;

                    case '5':
                        eTxtList[i] = '8';
                        break;

                    case 'e':
                        eTxtList[i] = '9';
                        break;
                }
                pTxtList.Add(eTxtList[i]);
            }

            string pTxt = string.Join("", pTxtList.ToArray());
            messageBox.Text = pTxt;
        }

        private void encryptedMessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearAllText_Click(object sender, EventArgs e)
        {
            messageBox.Clear();
            encryptedMessageBox.Clear();
            
        }
    }
}
