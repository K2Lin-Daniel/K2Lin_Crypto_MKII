namespace K2Lin_Crypto.Forms
{
    partial class StegoEncrypt
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
            this.selectImageButton = new MaterialSkin.Controls.MaterialButton();
            this.saveImageButton = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.encryptButton = new MaterialSkin.Controls.MaterialButton();
            this.encryptoText = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.receiverPublic = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblReciverPubKey = new MaterialSkin.Controls.MaterialLabel();
            this.lblTextEncrypt = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            //
            // selectImageButton
            //
            this.selectImageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectImageButton.Depth = 0;
            this.selectImageButton.DrawShadows = true;
            this.selectImageButton.HighEmphasis = true;
            this.selectImageButton.Icon = null;
            this.selectImageButton.Location = new System.Drawing.Point(12, 12);
            this.selectImageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.selectImageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(120, 36);
            this.selectImageButton.TabIndex = 0;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.selectImageButton.UseAccentColor = false;
            this.selectImageButton.UseVisualStyleBackColor = true;
            //
            // saveImageButton
            //
            this.saveImageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveImageButton.Depth = 0;
            this.saveImageButton.DrawShadows = true;
            this.saveImageButton.HighEmphasis = true;
            this.saveImageButton.Icon = null;
            this.saveImageButton.Location = new System.Drawing.Point(140, 12);
            this.saveImageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveImageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(118, 36);
            this.saveImageButton.TabIndex = 1;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveImageButton.UseAccentColor = false;
            this.saveImageButton.UseVisualStyleBackColor = true;
            //
            // pictureBox
            //
            this.pictureBox.Location = new System.Drawing.Point(12, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(246, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            //
            // encryptButton
            //
            this.encryptButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.encryptButton.Depth = 0;
            this.encryptButton.DrawShadows = true;
            this.encryptButton.HighEmphasis = true;
            this.encryptButton.Icon = null;
            this.encryptButton.Location = new System.Drawing.Point(12, 431);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.encryptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(246, 36);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "Encrypt and Embed";
            this.encryptButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.encryptButton.UseAccentColor = false;
            this.encryptButton.UseVisualStyleBackColor = true;
            //
            // encryptoText
            //
            this.encryptoText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.encryptoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encryptoText.Depth = 0;
            this.encryptoText.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.encryptoText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.encryptoText.Location = new System.Drawing.Point(12, 296);
            this.encryptoText.MouseState = MaterialSkin.MouseState.HOVER;
            this.encryptoText.Name = "encryptoText";
            this.encryptoText.Size = new System.Drawing.Size(246, 129);
            this.encryptoText.TabIndex = 4;
            this.encryptoText.Text = "";
            //
            // receiverPublic
            //
            this.receiverPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.receiverPublic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.receiverPublic.Depth = 0;
            this.receiverPublic.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.receiverPublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.receiverPublic.Location = new System.Drawing.Point(12, 232);
            this.receiverPublic.MouseState = MaterialSkin.MouseState.HOVER;
            this.receiverPublic.Name = "receiverPublic";
            this.receiverPublic.Size = new System.Drawing.Size(246, 58);
            this.receiverPublic.TabIndex = 5;
            this.receiverPublic.Text = "";
            //
            // lblReciverPubKey
            //
            this.lblReciverPubKey.AutoSize = true;
            this.lblReciverPubKey.Depth = 0;
            this.lblReciverPubKey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblReciverPubKey.Location = new System.Drawing.Point(12, 210);
            this.lblReciverPubKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReciverPubKey.Name = "lblReciverPubKey";
            this.lblReciverPubKey.Size = new System.Drawing.Size(133, 19);
            this.lblReciverPubKey.TabIndex = 6;
            this.lblReciverPubKey.Text = "Receiver Public Key:";
            //
            // lblTextEncrypt
            //
            this.lblTextEncrypt.AutoSize = true;
            this.lblTextEncrypt.Depth = 0;
            this.lblTextEncrypt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTextEncrypt.Location = new System.Drawing.Point(12, 274);
            this.lblTextEncrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTextEncrypt.Name = "lblTextEncrypt";
            this.lblTextEncrypt.Size = new System.Drawing.Size(103, 19);
            this.lblTextEncrypt.TabIndex = 7;
            this.lblTextEncrypt.Text = "Text to Encrypt:";
            //
            // StegoEncrypt
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 479);
            this.Controls.Add(this.lblTextEncrypt);
            this.Controls.Add(this.lblReciverPubKey);
            this.Controls.Add(this.receiverPublic);
            this.Controls.Add(this.encryptoText);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.selectImageButton);
            this.Name = "StegoEncrypt";
            this.Text = "StegoEncrypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton selectImageButton;
        private MaterialSkin.Controls.MaterialButton saveImageButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialButton encryptButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox encryptoText;
        private MaterialSkin.Controls.MaterialMultiLineTextBox receiverPublic;
        private MaterialSkin.Controls.MaterialLabel lblReciverPubKey;
        private MaterialSkin.Controls.MaterialLabel lblTextEncrypt;
    }
}
