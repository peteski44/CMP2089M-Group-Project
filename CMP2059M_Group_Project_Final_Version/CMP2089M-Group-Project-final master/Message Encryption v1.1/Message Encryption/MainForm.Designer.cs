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
            this.plainTxt_Lbl = new System.Windows.Forms.Label();
            this.encryptTxt_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.messageBox.Location = new System.Drawing.Point(12, 28);
            this.messageBox.MaxLength = 2500;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(213, 207);
            this.messageBox.TabIndex = 0;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // loadTextFile
            // 
            this.loadTextFile.BackColor = System.Drawing.SystemColors.Control;
            this.loadTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTextFile.Location = new System.Drawing.Point(12, 243);
            this.loadTextFile.Name = "loadTextFile";
            this.loadTextFile.Size = new System.Drawing.Size(96, 32);
            this.loadTextFile.TabIndex = 6;
            this.loadTextFile.Text = "Load Text File";
            this.loadTextFile.UseVisualStyleBackColor = false;
            this.loadTextFile.Click += new System.EventHandler(this.loadTextFile_Click);
            // 
            // saveToText
            // 
            this.saveToText.BackColor = System.Drawing.SystemColors.Control;
            this.saveToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToText.Location = new System.Drawing.Point(129, 243);
            this.saveToText.Name = "saveToText";
            this.saveToText.Size = new System.Drawing.Size(96, 32);
            this.saveToText.TabIndex = 7;
            this.saveToText.Text = "Save to Text";
            this.saveToText.UseVisualStyleBackColor = false;
            this.saveToText.Click += new System.EventHandler(this.saveToText_Click);
            // 
            // closeWindow
            // 
            this.closeWindow.BackColor = System.Drawing.SystemColors.Control;
            this.closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeWindow.Location = new System.Drawing.Point(248, 177);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(96, 32);
            this.closeWindow.TabIndex = 5;
            this.closeWindow.Text = "Exit";
            this.closeWindow.UseVisualStyleBackColor = false;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // encryptText
            // 
            this.encryptText.BackColor = System.Drawing.SystemColors.Control;
            this.encryptText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptText.Location = new System.Drawing.Point(248, 63);
            this.encryptText.Name = "encryptText";
            this.encryptText.Size = new System.Drawing.Size(96, 32);
            this.encryptText.TabIndex = 2;
            this.encryptText.Text = "Encrypt";
            this.encryptText.UseVisualStyleBackColor = false;
            this.encryptText.Click += new System.EventHandler(this.encryptText_Click);
            // 
            // decryptText
            // 
            this.decryptText.BackColor = System.Drawing.SystemColors.Control;
            this.decryptText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptText.Location = new System.Drawing.Point(248, 101);
            this.decryptText.Name = "decryptText";
            this.decryptText.Size = new System.Drawing.Size(96, 32);
            this.decryptText.TabIndex = 3;
            this.decryptText.Text = "Decrypt";
            this.decryptText.UseVisualStyleBackColor = false;
            this.decryptText.Click += new System.EventHandler(this.decryptText_Click);
            // 
            // saveToText2
            // 
            this.saveToText2.BackColor = System.Drawing.SystemColors.Control;
            this.saveToText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveToText2.Location = new System.Drawing.Point(491, 243);
            this.saveToText2.Name = "saveToText2";
            this.saveToText2.Size = new System.Drawing.Size(96, 32);
            this.saveToText2.TabIndex = 9;
            this.saveToText2.Text = "Save to Text";
            this.saveToText2.UseVisualStyleBackColor = false;
            this.saveToText2.Click += new System.EventHandler(this.saveToText2_Click);
            // 
            // loadTextFile2
            // 
            this.loadTextFile2.BackColor = System.Drawing.SystemColors.Control;
            this.loadTextFile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTextFile2.Location = new System.Drawing.Point(374, 243);
            this.loadTextFile2.Name = "loadTextFile2";
            this.loadTextFile2.Size = new System.Drawing.Size(96, 32);
            this.loadTextFile2.TabIndex = 8;
            this.loadTextFile2.Text = "Load Text File";
            this.loadTextFile2.UseVisualStyleBackColor = false;
            this.loadTextFile2.Click += new System.EventHandler(this.loadTextFile2_Click);
            // 
            // encryptedMessageBox
            // 
            this.encryptedMessageBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.encryptedMessageBox.Location = new System.Drawing.Point(374, 28);
            this.encryptedMessageBox.MaxLength = 2500;
            this.encryptedMessageBox.Name = "encryptedMessageBox";
            this.encryptedMessageBox.Size = new System.Drawing.Size(213, 207);
            this.encryptedMessageBox.TabIndex = 1;
            this.encryptedMessageBox.Text = "";
            this.encryptedMessageBox.TextChanged += new System.EventHandler(this.encryptedMessageBox_TextChanged);
            // 
            // clearAllText
            // 
            this.clearAllText.BackColor = System.Drawing.SystemColors.Control;
            this.clearAllText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllText.Location = new System.Drawing.Point(248, 139);
            this.clearAllText.Name = "clearAllText";
            this.clearAllText.Size = new System.Drawing.Size(96, 32);
            this.clearAllText.TabIndex = 4;
            this.clearAllText.Text = "Clear All";
            this.clearAllText.UseVisualStyleBackColor = false;
            this.clearAllText.Click += new System.EventHandler(this.clearAllText_Click);
            // 
            // plainTxt_Lbl
            // 
            this.plainTxt_Lbl.AutoSize = true;
            this.plainTxt_Lbl.Location = new System.Drawing.Point(12, 13);
            this.plainTxt_Lbl.Name = "plainTxt_Lbl";
            this.plainTxt_Lbl.Size = new System.Drawing.Size(54, 13);
            this.plainTxt_Lbl.TabIndex = 10;
            this.plainTxt_Lbl.Text = "Plain Text";
            // 
            // encryptTxt_Lbl
            // 
            this.encryptTxt_Lbl.AutoSize = true;
            this.encryptTxt_Lbl.Location = new System.Drawing.Point(374, 13);
            this.encryptTxt_Lbl.Name = "encryptTxt_Lbl";
            this.encryptTxt_Lbl.Size = new System.Drawing.Size(79, 13);
            this.encryptTxt_Lbl.TabIndex = 11;
            this.encryptTxt_Lbl.Text = "Encrypted Text";
            // 
            // encryptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(603, 319);
            this.Controls.Add(this.encryptTxt_Lbl);
            this.Controls.Add(this.plainTxt_Lbl);
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
            this.Text = "Message Encryption";
            this.Load += new System.EventHandler(this.encryptionWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label plainTxt_Lbl;
        private System.Windows.Forms.Label encryptTxt_Lbl;
    }
}

