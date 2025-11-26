namespace K2Lin_Crypto.Forms
{
    partial class StegoDecrypt
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.decryptButton = new MaterialSkin.Controls.MaterialButton();
            this.decryptoResult = new MaterialSkin.Controls.MaterialMultiLineTextBox();
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
            this.selectImageButton.Size = new System.Drawing.Size(246, 36);
            this.selectImageButton.TabIndex = 0;
            this.selectImageButton.Text = "Select Image";
            this.selectImageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.selectImageButton.UseAccentColor = false;
            this.selectImageButton.UseVisualStyleBackColor = true;
            //
            // pictureBox
            //
            this.pictureBox.Location = new System.Drawing.Point(12, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(246, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            //
            // decryptButton
            //
            this.decryptButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.decryptButton.Depth = 0;
            this.decryptButton.DrawShadows = true;
            this.decryptButton.HighEmphasis = true;
            this.decryptButton.Icon = null;
            this.decryptButton.Location = new System.Drawing.Point(12, 216);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.decryptButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(246, 36);
            this.decryptButton.TabIndex = 2;
            this.decryptButton.Text = "Decrypt and Extract";
            this.decryptButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.decryptButton.UseAccentColor = false;
            this.decryptButton.UseVisualStyleBackColor = true;
            //
            // decryptoResult
            //
            this.decryptoResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.decryptoResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decryptoResult.Depth = 0;
            this.decryptoResult.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.decryptoResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.decryptoResult.Location = new System.Drawing.Point(12, 261);
            this.decryptoResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.decryptoResult.Name = "decryptoResult";
            this.decryptoResult.Size = new System.Drawing.Size(246, 150);
            this.decryptoResult.TabIndex = 3;
            this.decryptoResult.Text = "";
            //
            // StegoDecrypt
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 423);
            this.Controls.Add(this.decryptoResult);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.selectImageButton);
            this.Name = "StegoDecrypt";
            this.Text = "StegoDecrypt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton selectImageButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private MaterialSkin.Controls.MaterialButton decryptButton;
        private MaterialSkin.Controls.MaterialMultiLineTextBox decryptoResult;
    }
}
