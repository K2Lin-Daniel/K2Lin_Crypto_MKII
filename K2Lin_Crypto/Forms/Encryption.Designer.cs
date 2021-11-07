namespace K2Lin_Crypto.Forms
{
    partial class Encryption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReceiverPublic = new System.Windows.Forms.TextBox();
            this.lblReciverPubKey = new System.Windows.Forms.Label();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.EncryptSessionID = new System.Windows.Forms.TextBox();
            this.lblTextEncrypt = new System.Windows.Forms.Label();
            this.EncryptoText = new System.Windows.Forms.TextBox();
            this.lblCiperText = new System.Windows.Forms.Label();
            this.EncryptoResult = new System.Windows.Forms.TextBox();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.CopyEncryptedText = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::K2Lin_Crypto.Properties.Resources.lock_icon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // ReceiverPublic
            // 
            resources.ApplyResources(this.ReceiverPublic, "ReceiverPublic");
            this.ReceiverPublic.Name = "ReceiverPublic";
            this.ReceiverPublic.TextChanged += new System.EventHandler(this.ReceiverPublic_TextChanged);
            // 
            // lblReciverPubKey
            // 
            resources.ApplyResources(this.lblReciverPubKey, "lblReciverPubKey");
            this.lblReciverPubKey.Name = "lblReciverPubKey";
            // 
            // lblSessionID
            // 
            resources.ApplyResources(this.lblSessionID, "lblSessionID");
            this.lblSessionID.Name = "lblSessionID";
            // 
            // EncryptSessionID
            // 
            resources.ApplyResources(this.EncryptSessionID, "EncryptSessionID");
            this.EncryptSessionID.Name = "EncryptSessionID";
            this.EncryptSessionID.ReadOnly = true;
            // 
            // lblTextEncrypt
            // 
            resources.ApplyResources(this.lblTextEncrypt, "lblTextEncrypt");
            this.lblTextEncrypt.Name = "lblTextEncrypt";
            // 
            // EncryptoText
            // 
            resources.ApplyResources(this.EncryptoText, "EncryptoText");
            this.EncryptoText.Name = "EncryptoText";
            // 
            // lblCiperText
            // 
            resources.ApplyResources(this.lblCiperText, "lblCiperText");
            this.lblCiperText.Name = "lblCiperText";
            // 
            // EncryptoResult
            // 
            resources.ApplyResources(this.EncryptoResult, "EncryptoResult");
            this.EncryptoResult.Name = "EncryptoResult";
            this.EncryptoResult.ReadOnly = true;
            this.EncryptoResult.TextChanged += new System.EventHandler(this.EncryptoResult_TextChanged);
            // 
            // EncryptButton
            // 
            resources.ApplyResources(this.EncryptButton, "EncryptButton");
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // CopyEncryptedText
            // 
            resources.ApplyResources(this.CopyEncryptedText, "CopyEncryptedText");
            this.CopyEncryptedText.Name = "CopyEncryptedText";
            this.CopyEncryptedText.UseVisualStyleBackColor = true;
            this.CopyEncryptedText.Click += new System.EventHandler(this.CopyEncryptedText_Click);
            // 
            // Encryption
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CopyEncryptedText);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.EncryptoResult);
            this.Controls.Add(this.lblCiperText);
            this.Controls.Add(this.EncryptoText);
            this.Controls.Add(this.lblTextEncrypt);
            this.Controls.Add(this.EncryptSessionID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.lblReciverPubKey);
            this.Controls.Add(this.ReceiverPublic);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Encryption";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ReceiverPublic;
        private System.Windows.Forms.Label lblReciverPubKey;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.TextBox EncryptSessionID;
        private System.Windows.Forms.Label lblTextEncrypt;
        private System.Windows.Forms.TextBox EncryptoText;
        private System.Windows.Forms.Label lblCiperText;
        private System.Windows.Forms.TextBox EncryptoResult;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button CopyEncryptedText;
    }
}