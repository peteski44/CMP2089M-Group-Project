namespace Message_Encryption
{
    partial class encryptionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.loadTextFile = new System.Windows.Forms.Button();
            this.saveToText = new System.Windows.Forms.Button();
            this.closeWindow = new System.Windows.Forms.Button();
            this.encryptText = new System.Windows.Forms.Button();
            this.decrpytText = new System.Windows.Forms.Button();
            this.saveToText2 = new System.Windows.Forms.Button();
            this.loadTextFile2 = new System.Windows.Forms.Button();
            this.encryptedMessageBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.messageBox.Location = new System.Drawing.Point(12, 12);
            this.messageBox.MaxLength = 2500;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(213, 218);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // loadTextFile
            // 
            this.loadTextFile.Location = new System.Drawing.Point(12, 236);
            this.loadTextFile.Name = "loadTextFile";
            this.loadTextFile.Size = new System.Drawing.Size(96, 27);
            this.loadTextFile.TabIndex = 1;
            this.loadTextFile.Text = "Load Text File";
            this.loadTextFile.UseVisualStyleBackColor = true;
            this.loadTextFile.Click += new System.EventHandler(this.loadTextFile_Click);
            // 
            // saveToText
            // 
            this.saveToText.Location = new System.Drawing.Point(129, 236);
            this.saveToText.Name = "saveToText";
            this.saveToText.Size = new System.Drawing.Size(96, 27);
            this.saveToText.TabIndex = 2;
            this.saveToText.Text = "Save To Text";
            this.saveToText.UseVisualStyleBackColor = true;
            this.saveToText.Click += new System.EventHandler(this.saveToText_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.Location = new System.Drawing.Point(333, 203);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(96, 27);
            this.closeWindow.TabIndex = 3;
            this.closeWindow.Text = "Close";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // encryptText
            // 
            this.encryptText.Location = new System.Drawing.Point(333, 121);
            this.encryptText.Name = "encryptText";
            this.encryptText.Size = new System.Drawing.Size(96, 38);
            this.encryptText.TabIndex = 4;
            this.encryptText.Text = "Encrpytion";
            this.encryptText.UseVisualStyleBackColor = true;
            this.encryptText.Click += new System.EventHandler(this.encryptText_Click);
            // 
            // decrpytText
            // 
            this.decrpytText.Location = new System.Drawing.Point(333, 165);
            this.decrpytText.Name = "decrpytText";
            this.decrpytText.Size = new System.Drawing.Size(96, 32);
            this.decrpytText.TabIndex = 5;
            this.decrpytText.Text = "Decryption";
            this.decrpytText.UseVisualStyleBackColor = true;
            this.decrpytText.Click += new System.EventHandler(this.decrpytText_Click);
            // 
            // saveToText2
            // 
            this.saveToText2.Location = new System.Drawing.Point(539, 236);
            this.saveToText2.Name = "saveToText2";
            this.saveToText2.Size = new System.Drawing.Size(96, 27);
            this.saveToText2.TabIndex = 7;
            this.saveToText2.Text = "Save To Text";
            this.saveToText2.UseVisualStyleBackColor = true;
            this.saveToText2.Click += new System.EventHandler(this.saveToText2_Click);
            // 
            // loadTextFile2
            // 
            this.loadTextFile2.Location = new System.Drawing.Point(656, 236);
            this.loadTextFile2.Name = "loadTextFile2";
            this.loadTextFile2.Size = new System.Drawing.Size(96, 27);
            this.loadTextFile2.TabIndex = 8;
            this.loadTextFile2.Text = "Load Text File";
            this.loadTextFile2.UseVisualStyleBackColor = true;
            this.loadTextFile2.Click += new System.EventHandler(this.loadTextFile2_Click);
            // 
            // encryptedMessageBox
            // 
            this.encryptedMessageBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.encryptedMessageBox.Location = new System.Drawing.Point(539, 12);
            this.encryptedMessageBox.MaxLength = 2500;
            this.encryptedMessageBox.Name = "encryptedMessageBox";
            this.encryptedMessageBox.Size = new System.Drawing.Size(213, 218);
            this.encryptedMessageBox.TabIndex = 9;
            this.encryptedMessageBox.Text = "";
            this.encryptedMessageBox.TextChanged += new System.EventHandler(this.encryptedMessageBox_TextChanged);
            // 
            // encryptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(764, 319);
            this.Controls.Add(this.encryptedMessageBox);
            this.Controls.Add(this.loadTextFile2);
            this.Controls.Add(this.saveToText2);
            this.Controls.Add(this.decrpytText);
            this.Controls.Add(this.encryptText);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.saveToText);
            this.Controls.Add(this.loadTextFile);
            this.Controls.Add(this.messageBox);
            this.Name = "encryptionWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.encryptionWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.Button loadTextFile;
        private System.Windows.Forms.Button saveToText;
        private System.Windows.Forms.Button closeWindow;
        private System.Windows.Forms.Button encryptText;
        private System.Windows.Forms.Button decrpytText;
        private System.Windows.Forms.Button saveToText2;
        private System.Windows.Forms.Button loadTextFile2;
        private System.Windows.Forms.RichTextBox encryptedMessageBox;
    }
}

