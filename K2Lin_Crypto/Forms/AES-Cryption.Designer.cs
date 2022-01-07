namespace K2Lin_Crypto.Forms
{
    partial class AESEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AESEncrypt));
            this.lblOriginText = new System.Windows.Forms.Label();
            this.OriginText = new System.Windows.Forms.TextBox();
            this.CryptButton = new System.Windows.Forms.Button();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.CopyDecryptedText = new System.Windows.Forms.Button();
            this.lblPassKey = new System.Windows.Forms.Label();
            this.PassKey = new System.Windows.Forms.TextBox();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.KeyID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GenerateKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOriginText
            // 
            resources.ApplyResources(this.lblOriginText, "lblOriginText");
            this.lblOriginText.Name = "lblOriginText";
            // 
            // OriginText
            // 
            this.OriginText.AcceptsReturn = true;
            this.OriginText.AcceptsTab = true;
            this.OriginText.AllowDrop = true;
            resources.ApplyResources(this.OriginText, "OriginText");
            this.OriginText.Name = "OriginText";
            // 
            // CryptButton
            // 
            resources.ApplyResources(this.CryptButton, "CryptButton");
            this.CryptButton.Name = "CryptButton";
            this.CryptButton.UseVisualStyleBackColor = true;
            this.CryptButton.Click += new System.EventHandler(this.CryptButton_Click);
            // 
            // ResultText
            // 
            resources.ApplyResources(this.ResultText, "ResultText");
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            // 
            // CopyDecryptedText
            // 
            resources.ApplyResources(this.CopyDecryptedText, "CopyDecryptedText");
            this.CopyDecryptedText.Name = "CopyDecryptedText";
            this.CopyDecryptedText.UseVisualStyleBackColor = true;
            this.CopyDecryptedText.Click += new System.EventHandler(this.CopyDecryptedText_Click);
            // 
            // lblPassKey
            // 
            resources.ApplyResources(this.lblPassKey, "lblPassKey");
            this.lblPassKey.Name = "lblPassKey";
            // 
            // PassKey
            // 
            resources.ApplyResources(this.PassKey, "PassKey");
            this.PassKey.Name = "PassKey";
            this.PassKey.TextChanged += new System.EventHandler(this.PassKey_TextChanged);
            // 
            // lblSessionID
            // 
            resources.ApplyResources(this.lblSessionID, "lblSessionID");
            this.lblSessionID.Name = "lblSessionID";
            // 
            // KeyID
            // 
            resources.ApplyResources(this.KeyID, "KeyID");
            this.KeyID.Name = "KeyID";
            this.KeyID.ReadOnly = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // GenerateKey
            // 
            resources.ApplyResources(this.GenerateKey, "GenerateKey");
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.UseVisualStyleBackColor = true;
            this.GenerateKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // AESEncrypt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenerateKey);
            this.Controls.Add(this.KeyID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.PassKey);
            this.Controls.Add(this.lblPassKey);
            this.Controls.Add(this.CopyDecryptedText);
            this.Controls.Add(this.ResultText);
            this.Controls.Add(this.CryptButton);
            this.Controls.Add(this.OriginText);
            this.Controls.Add(this.lblOriginText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AESEncrypt";
            this.Load += new System.EventHandler(this.AESEncrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOriginText;
        private System.Windows.Forms.TextBox OriginText;
        private System.Windows.Forms.Button CryptButton;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button CopyDecryptedText;
        private System.Windows.Forms.Label lblPassKey;
        private System.Windows.Forms.TextBox PassKey;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.TextBox KeyID;
        private System.Windows.Forms.Button GenerateKey;
    }
}