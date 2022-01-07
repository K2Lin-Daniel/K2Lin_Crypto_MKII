namespace K2Lin_Crypto.Forms
{
    partial class Decryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decryption));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.SessionID = new System.Windows.Forms.TextBox();
            this.CopyPublicKey = new System.Windows.Forms.Button();
            this.lblTextDecrypt = new System.Windows.Forms.Label();
            this.DecryptoText = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.lblDecryptedText = new System.Windows.Forms.Label();
            this.CopyDecryptedText = new System.Windows.Forms.Button();
            this.DecryptoResult = new System.Windows.Forms.TextBox();
            this.SessionIDIncorrect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::K2Lin_Crypto.Properties.Resources.unlock_icon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lblSessionID
            // 
            resources.ApplyResources(this.lblSessionID, "lblSessionID");
            this.lblSessionID.Name = "lblSessionID";
            // 
            // SessionID
            // 
            resources.ApplyResources(this.SessionID, "SessionID");
            this.SessionID.Name = "SessionID";
            this.SessionID.ReadOnly = true;
            // 
            // CopyPublicKey
            // 
            resources.ApplyResources(this.CopyPublicKey, "CopyPublicKey");
            this.CopyPublicKey.Name = "CopyPublicKey";
            this.CopyPublicKey.UseVisualStyleBackColor = true;
            this.CopyPublicKey.Click += new System.EventHandler(this.CopyPublicKey_Click);
            // 
            // lblTextDecrypt
            // 
            resources.ApplyResources(this.lblTextDecrypt, "lblTextDecrypt");
            this.lblTextDecrypt.Name = "lblTextDecrypt";
            // 
            // DecryptoText
            // 
            resources.ApplyResources(this.DecryptoText, "DecryptoText");
            this.DecryptoText.Name = "DecryptoText";
            // 
            // DecryptButton
            // 
            resources.ApplyResources(this.DecryptButton, "DecryptButton");
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // lblDecryptedText
            // 
            resources.ApplyResources(this.lblDecryptedText, "lblDecryptedText");
            this.lblDecryptedText.Name = "lblDecryptedText";
            // 
            // CopyDecryptedText
            // 
            resources.ApplyResources(this.CopyDecryptedText, "CopyDecryptedText");
            this.CopyDecryptedText.Name = "CopyDecryptedText";
            this.CopyDecryptedText.UseVisualStyleBackColor = true;
            this.CopyDecryptedText.Click += new System.EventHandler(this.CopyDecryptedText_Click);
            // 
            // DecryptoResult
            // 
            resources.ApplyResources(this.DecryptoResult, "DecryptoResult");
            this.DecryptoResult.Name = "DecryptoResult";
            this.DecryptoResult.ReadOnly = true;
            // 
            // SessionIDIncorrect
            // 
            resources.ApplyResources(this.SessionIDIncorrect, "SessionIDIncorrect");
            this.SessionIDIncorrect.ForeColor = System.Drawing.Color.Red;
            this.SessionIDIncorrect.Name = "SessionIDIncorrect";
            // 
            // Decryption
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SessionIDIncorrect);
            this.Controls.Add(this.CopyDecryptedText);
            this.Controls.Add(this.DecryptoResult);
            this.Controls.Add(this.lblDecryptedText);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.DecryptoText);
            this.Controls.Add(this.lblTextDecrypt);
            this.Controls.Add(this.CopyPublicKey);
            this.Controls.Add(this.SessionID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Decryption";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.TextBox SessionID;
        private System.Windows.Forms.Button CopyPublicKey;
        private System.Windows.Forms.Label lblTextDecrypt;
        private System.Windows.Forms.TextBox DecryptoText;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label lblDecryptedText;
        private System.Windows.Forms.Button CopyDecryptedText;
        private System.Windows.Forms.TextBox DecryptoResult;
        private System.Windows.Forms.Label SessionIDIncorrect;
    }
}