namespace K2Lin_Crypto.Forms
{
    partial class Keypairs
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
            this.lblPubKey = new MaterialSkin.Controls.MaterialLabel();
            this.pubkey = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblPrivKey = new MaterialSkin.Controls.MaterialLabel();
            this.privkey = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.lblSessionID = new MaterialSkin.Controls.MaterialLabel();
            this.SessionID = new MaterialSkin.Controls.MaterialTextBox();
            this.lblSelectLength = new MaterialSkin.Controls.MaterialLabel();
            this.Sel2048 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Sel4096 = new MaterialSkin.Controls.MaterialRadioButton();
            this.Sel8192 = new MaterialSkin.Controls.MaterialRadioButton();
            this.generate = new MaterialSkin.Controls.MaterialButton();
            this.Export = new MaterialSkin.Controls.MaterialButton();
            this.Import = new MaterialSkin.Controls.MaterialButton();
            this.lblTFA = new MaterialSkin.Controls.MaterialLabel();
            this.TFAPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.SaveXML = new System.Windows.Forms.SaveFileDialog();
            this.ReadXML = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            //
            // lblPubKey
            //
            this.lblPubKey.AutoSize = true;
            this.lblPubKey.Depth = 0;
            this.lblPubKey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPubKey.Location = new System.Drawing.Point(12, 9);
            this.lblPubKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPubKey.Name = "lblPubKey";
            this.lblPubKey.Size = new System.Drawing.Size(78, 19);
            this.lblPubKey.TabIndex = 0;
            this.lblPubKey.Text = "Public Key:";
            //
            // pubkey
            //
            this.pubkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pubkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pubkey.Depth = 0;
            this.pubkey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pubkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pubkey.Location = new System.Drawing.Point(12, 31);
            this.pubkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.pubkey.Name = "pubkey";
            this.pubkey.Size = new System.Drawing.Size(400, 100);
            this.pubkey.TabIndex = 1;
            this.pubkey.Text = "";
            //
            // lblPrivKey
            //
            this.lblPrivKey.AutoSize = true;
            this.lblPrivKey.Depth = 0;
            this.lblPrivKey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrivKey.Location = new System.Drawing.Point(12, 134);
            this.lblPrivKey.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrivKey.Name = "lblPrivKey";
            this.lblPrivKey.Size = new System.Drawing.Size(82, 19);
            this.lblPrivKey.TabIndex = 2;
            this.lblPrivKey.Text = "Private Key:";
            //
            // privkey
            //
            this.privkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.privkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.privkey.Depth = 0;
            this.privkey.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.privkey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.privkey.Location = new System.Drawing.Point(12, 156);
            this.privkey.MouseState = MaterialSkin.MouseState.HOVER;
            this.privkey.Name = "privkey";
            this.privkey.Size = new System.Drawing.Size(400, 100);
            this.privkey.TabIndex = 3;
            this.privkey.Text = "";
            //
            // lblSessionID
            //
            this.lblSessionID.AutoSize = true;
            this.lblSessionID.Depth = 0;
            this.lblSessionID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSessionID.Location = new System.Drawing.Point(12, 259);
            this.lblSessionID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSessionID.Name = "lblSessionID";
            this.lblSessionID.Size = new System.Drawing.Size(78, 19);
            this.lblSessionID.TabIndex = 4;
            this.lblSessionID.Text = "Session ID:";
            //
            // SessionID
            //
            this.SessionID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SessionID.Depth = 0;
            this.SessionID.Font = new System.Drawing.Font("Roboto", 12F);
            this.SessionID.Location = new System.Drawing.Point(12, 281);
            this.SessionID.MaxLength = 50;
            this.SessionID.MouseState = MaterialSkin.MouseState.OUT;
            this.SessionID.Multiline = false;
            this.SessionID.Name = "SessionID";
            this.SessionID.Size = new System.Drawing.Size(400, 50);
            this.SessionID.TabIndex = 5;
            this.SessionID.Text = "";
            //
            // lblSelectLength
            //
            this.lblSelectLength.AutoSize = true;
            this.lblSelectLength.Depth = 0;
            this.lblSelectLength.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblSelectLength.Location = new System.Drawing.Point(418, 9);
            this.lblSelectLength.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSelectLength.Name = "lblSelectLength";
            this.lblSelectLength.Size = new System.Drawing.Size(125, 19);
            this.lblSelectLength.TabIndex = 6;
            this.lblSelectLength.Text = "Select Key Length:";
            //
            // Sel2048
            //
            this.Sel2048.AutoSize = true;
            this.Sel2048.Checked = true;
            this.Sel2048.Depth = 0;
            this.Sel2048.Location = new System.Drawing.Point(418, 31);
            this.Sel2048.Margin = new System.Windows.Forms.Padding(0);
            this.Sel2048.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Sel2048.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sel2048.Name = "Sel2048";
            this.Sel2048.Ripple = true;
            this.Sel2048.Size = new System.Drawing.Size(69, 37);
            this.Sel2048.TabIndex = 7;
            this.Sel2048.TabStop = true;
            this.Sel2048.Text = "2048";
            this.Sel2048.UseVisualStyleBackColor = true;
            //
            // Sel4096
            //
            this.Sel4096.AutoSize = true;
            this.Sel4096.Depth = 0;
            this.Sel4096.Location = new System.Drawing.Point(418, 68);
            this.Sel4096.Margin = new System.Windows.Forms.Padding(0);
            this.Sel4096.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Sel4096.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sel4096.Name = "Sel4096";
            this.Sel4096.Ripple = true;
            this.Sel4096.Size = new System.Drawing.Size(69, 37);
            this.Sel4096.TabIndex = 8;
            this.Sel4096.TabStop = true;
            this.Sel4096.Text = "4096";
            this.Sel4096.UseVisualStyleBackColor = true;
            //
            // Sel8192
            //
            this.Sel8192.AutoSize = true;
            this.Sel8192.Depth = 0;
            this.Sel8192.Location = new System.Drawing.Point(418, 105);
            this.Sel8192.Margin = new System.Windows.Forms.Padding(0);
            this.Sel8192.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Sel8192.MouseState = MaterialSkin.MouseState.HOVER;
            this.Sel8192.Name = "Sel8192";
            this.Sel8192.Ripple = true;
            this.Sel8192.Size = new System.Drawing.Size(69, 37);
            this.Sel8192.TabIndex = 9;
            this.Sel8192.TabStop = true;
            this.Sel8192.Text = "8192";
            this.Sel8192.UseVisualStyleBackColor = true;
            //
            // generate
            //
            this.generate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generate.Depth = 0;
            this.generate.DrawShadows = true;
            this.generate.HighEmphasis = true;
            this.generate.Icon = null;
            this.generate.Location = new System.Drawing.Point(418, 156);
            this.generate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.generate.MouseState = MaterialSkin.MouseState.HOVER;
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(88, 36);
            this.generate.TabIndex = 10;
            this.generate.Text = "Generate";
            this.generate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.generate.UseAccentColor = false;
            this.generate.UseVisualStyleBackColor = true;
            //
            // Export
            //
            this.Export.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Export.Depth = 0;
            this.Export.DrawShadows = true;
            this.Export.HighEmphasis = true;
            this.Export.Icon = null;
            this.Export.Location = new System.Drawing.Point(418, 201);
            this.Export.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Export.MouseState = MaterialSkin.MouseState.HOVER;
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(69, 36);
            this.Export.TabIndex = 11;
            this.Export.Text = "Export";
            this.Export.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Export.UseAccentColor = false;
            this.Export.UseVisualStyleBackColor = true;
            //
            // Import
            //
            this.Import.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Import.Depth = 0;
            this.Import.DrawShadows = true;
            this.Import.HighEmphasis = true;
            this.Import.Icon = null;
            this.Import.Location = new System.Drawing.Point(418, 246);
            this.Import.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Import.MouseState = MaterialSkin.MouseState.HOVER;
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(69, 36);
            this.Import.TabIndex = 12;
            this.Import.Text = "Import";
            this.Import.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Import.UseAccentColor = false;
            this.Import.UseVisualStyleBackColor = true;
            //
            // lblTFA
            //
            this.lblTFA.AutoSize = true;
            this.lblTFA.Depth = 0;
            this.lblTFA.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTFA.Location = new System.Drawing.Point(12, 334);
            this.lblTFA.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTFA.Name = "lblTFA";
            this.lblTFA.Size = new System.Drawing.Size(107, 19);
            this.lblTFA.TabIndex = 13;
            this.lblTFA.Text = "2FA Password:";
            //
            // TFAPassword
            //
            this.TFAPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TFAPassword.Depth = 0;
            this.TFAPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.TFAPassword.Location = new System.Drawing.Point(12, 356);
            this.TFAPassword.MaxLength = 50;
            this.TFAPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.TFAPassword.Multiline = false;
            this.TFAPassword.Name = "TFAPassword";
            this.TFAPassword.Size = new System.Drawing.Size(400, 50);
            this.TFAPassword.TabIndex = 14;
            this.TFAPassword.Text = "";
            //
            // ReadXML
            //
            this.ReadXML.FileName = "openFileDialog1";
            //
            // Keypairs
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.TFAPassword);
            this.Controls.Add(this.lblTFA);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.Sel8192);
            this.Controls.Add(this.Sel4096);
            this.Controls.Add(this.Sel2048);
            this.Controls.Add(this.lblSelectLength);
            this.Controls.Add(this.SessionID);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.privkey);
            this.Controls.Add(this.lblPrivKey);
            this.Controls.Add(this.pubkey);
            this.Controls.Add(this.lblPubKey);
            this.Name = "Keypairs";
            this.Text = "Keypairs";
            this.Load += new System.EventHandler(this.Keypairs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblPubKey;
        private MaterialSkin.Controls.MaterialMultiLineTextBox pubkey;
        private MaterialSkin.Controls.MaterialLabel lblPrivKey;
        private MaterialSkin.Controls.MaterialMultiLineTextBox privkey;
        private MaterialSkin.Controls.MaterialLabel lblSessionID;
        private MaterialSkin.Controls.MaterialTextBox SessionID;
        private MaterialSkin.Controls.MaterialLabel lblSelectLength;
        private MaterialSkin.Controls.MaterialRadioButton Sel2048;
        private MaterialSkin.Controls.MaterialRadioButton Sel4096;
        private MaterialSkin.Controls.MaterialRadioButton Sel8192;
        private MaterialSkin.Controls.MaterialButton generate;
        private MaterialSkin.Controls.MaterialButton Export;
        private MaterialSkin.Controls.MaterialButton Import;
        private MaterialSkin.Controls.MaterialLabel lblTFA;
        private MaterialSkin.Controls.MaterialTextBox TFAPassword;
        private System.Windows.Forms.SaveFileDialog SaveXML;
        private System.Windows.Forms.OpenFileDialog ReadXML;
    }
}
