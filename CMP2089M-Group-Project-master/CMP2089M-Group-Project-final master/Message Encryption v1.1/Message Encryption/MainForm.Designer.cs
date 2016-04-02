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
            this.decryptText = new System.Windows.Forms.Button();
            this.saveToText2 = new System.Windows.Forms.Button();
            this.loadTextFile2 = new System.Windows.Forms.Button();
            this.encryptedMessageBox = new System.Windows.Forms.RichTextBox();
            this.clearAllText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.messageBox.Location = new System.Drawing.Point(12, 12);
            this.messageBox.MaxLength = 2500;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(213, 207);
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
            this.closeWindow.Location = new System.Drawing.Point(248, 171);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(96, 27);
            this.closeWindow.TabIndex = 3;
            this.closeWindow.Text = "Exit";
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // encryptText
            // 
            this.encryptText.Location = new System.Drawing.Point(248, 12);
            this.encryptText.Name = "encryptText";
            this.encryptText.Size = new System.Drawing.Size(96, 38);
            this.encryptText.TabIndex = 4;
            this.encryptText.Text = "Encrypt";
            this.encryptText.UseVisualStyleBackColor = true;
            this.encryptText.Click += new System.EventHandler(this.encryptText_Click);
            // 
            // decryptText
            // 
            this.decryptText.Location = new System.Drawing.Point(248, 65);
            this.decryptText.Name = "decryptText";
            this.decryptText.Size = new System.Drawing.Size(96, 32);
            this.decryptText.TabIndex = 5;
            this.decryptText.Text = "Decrypt";
            this.decryptText.UseVisualStyleBackColor = true;
            this.decryptText.Click += new System.EventHandler(this.decryptText_Click);
            // 
            // saveToText2
            // 
            this.saveToText2.Location = new System.Drawing.Point(374, 236);
            this.saveToText2.Name = "saveToText2";
            this.saveToText2.Size = new System.Drawing.Size(96, 27);
            this.saveToText2.TabIndex = 7;
            this.saveToText2.Text = "Save To Text";
            this.saveToText2.UseVisualStyleBackColor = true;
            this.saveToText2.Click += new System.EventHandler(this.saveToText2_Click);
            // 
            // loadTextFile2
            // 
            this.loadTextFile2.Location = new System.Drawing.Point(491, 236);
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
            this.encryptedMessageBox.Location = new System.Drawing.Point(374, 12);
            this.encryptedMessageBox.MaxLength = 2500;
            this.encryptedMessageBox.Name = "encryptedMessageBox";
            this.encryptedMessageBox.Size = new System.Drawing.Size(213, 207);
            this.encryptedMessageBox.TabIndex = 9;
            this.encryptedMessageBox.Text = "";
            this.encryptedMessageBox.TextChanged += new System.EventHandler(this.encryptedMessageBox_TextChanged);
            // 
            // clearAllText
            // 
            this.clearAllText.Location = new System.Drawing.Point(248, 120);
            this.clearAllText.Name = "clearAllText";
            this.clearAllText.Size = new System.Drawing.Size(96, 28);
            this.clearAllText.TabIndex = 10;
            this.clearAllText.Text = "Clear All";
            this.clearAllText.UseVisualStyleBackColor = true;
            this.clearAllText.Click += new System.EventHandler(this.clearAllText_Click);
            // 
            // encryptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(603, 319);
            this.Controls.Add(this.clearAllText);
            this.Controls.Add(this.encryptedMessageBox);
            this.Controls.Add(this.loadTextFile2);
            this.Controls.Add(this.saveToText2);
            this.Controls.Add(this.decryptText);
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
        private System.Windows.Forms.Button decryptText;
        private System.Windows.Forms.Button saveToText2;
        private System.Windows.Forms.Button loadTextFile2;
        private System.Windows.Forms.RichTextBox encryptedMessageBox;
        private System.Windows.Forms.Button clearAllText;
    }
}

