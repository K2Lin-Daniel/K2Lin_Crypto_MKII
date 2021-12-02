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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Keypairs));
            this.lblPubKey = new System.Windows.Forms.Label();
            this.lblPrivKey = new System.Windows.Forms.Label();
            this.pubkey = new System.Windows.Forms.TextBox();
            this.privkey = new System.Windows.Forms.TextBox();
            this.Sel2048 = new System.Windows.Forms.RadioButton();
            this.Sel4096 = new System.Windows.Forms.RadioButton();
            this.Sel8192 = new System.Windows.Forms.RadioButton();
            this.lblSelectLength = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.SessionID = new System.Windows.Forms.TextBox();
            this.lblSessionID = new System.Windows.Forms.Label();
            this.SaveXML = new System.Windows.Forms.SaveFileDialog();
            this.ReadXML = new System.Windows.Forms.OpenFileDialog();
            this.lblKeyFile = new System.Windows.Forms.Label();
            this.lblEncryptNote = new System.Windows.Forms.Label();
            this.lblTFA = new System.Windows.Forms.Label();
            this.TFAPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Export = new System.Windows.Forms.PictureBox();
            this.Import = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Import)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPubKey
            // 
            resources.ApplyResources(this.lblPubKey, "lblPubKey");
            this.lblPubKey.Name = "lblPubKey";
            // 
            // lblPrivKey
            // 
            resources.ApplyResources(this.lblPrivKey, "lblPrivKey");
            this.lblPrivKey.Name = "lblPrivKey";
            // 
            // pubkey
            // 
            resources.ApplyResources(this.pubkey, "pubkey");
            this.pubkey.Name = "pubkey";
            this.pubkey.ReadOnly = true;
            // 
            // privkey
            // 
            resources.ApplyResources(this.privkey, "privkey");
            this.privkey.Name = "privkey";
            this.privkey.ReadOnly = true;
            // 
            // Sel2048
            // 
            resources.ApplyResources(this.Sel2048, "Sel2048");
            this.Sel2048.Checked = true;
            this.Sel2048.Name = "Sel2048";
            this.Sel2048.TabStop = true;
            this.Sel2048.UseVisualStyleBackColor = true;
            this.Sel2048.CheckedChanged += new System.EventHandler(this.Sel2048_CheckedChanged);
            // 
            // Sel4096
            // 
            resources.ApplyResources(this.Sel4096, "Sel4096");
            this.Sel4096.Name = "Sel4096";
            this.Sel4096.UseVisualStyleBackColor = true;
            this.Sel4096.CheckedChanged += new System.EventHandler(this.Sel4096_CheckedChanged);
            // 
            // Sel8192
            // 
            resources.ApplyResources(this.Sel8192, "Sel8192");
            this.Sel8192.Name = "Sel8192";
            this.Sel8192.UseVisualStyleBackColor = true;
            this.Sel8192.CheckedChanged += new System.EventHandler(this.Sel8192_CheckedChanged);
            // 
            // lblSelectLength
            // 
            resources.ApplyResources(this.lblSelectLength, "lblSelectLength");
            this.lblSelectLength.Name = "lblSelectLength";
            // 
            // generate
            // 
            resources.ApplyResources(this.generate, "generate");
            this.generate.Name = "generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // SessionID
            // 
            resources.ApplyResources(this.SessionID, "SessionID");
            this.SessionID.Name = "SessionID";
            this.SessionID.ReadOnly = true;
            // 
            // lblSessionID
            // 
            resources.ApplyResources(this.lblSessionID, "lblSessionID");
            this.lblSessionID.Name = "lblSessionID";
            // 
            // SaveXML
            // 
            this.SaveXML.DefaultExt = "xml";
            resources.ApplyResources(this.SaveXML, "SaveXML");
            // 
            // ReadXML
            // 
            this.ReadXML.DefaultExt = "xml";
            this.ReadXML.FileName = "openFileDialog1";
            resources.ApplyResources(this.ReadXML, "ReadXML");
            // 
            // lblKeyFile
            // 
            resources.ApplyResources(this.lblKeyFile, "lblKeyFile");
            this.lblKeyFile.Name = "lblKeyFile";
            // 
            // lblEncryptNote
            // 
            resources.ApplyResources(this.lblEncryptNote, "lblEncryptNote");
            this.lblEncryptNote.Name = "lblEncryptNote";
            // 
            // lblTFA
            // 
            resources.ApplyResources(this.lblTFA, "lblTFA");
            this.lblTFA.Name = "lblTFA";
            // 
            // TFAPassword
            // 
            resources.ApplyResources(this.TFAPassword, "TFAPassword");
            this.TFAPassword.Name = "TFAPassword";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::K2Lin_Crypto.Properties.Resources.encryptedFile;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Export
            // 
            resources.ApplyResources(this.Export, "Export");
            this.Export.Image = global::K2Lin_Crypto.Properties.Resources.downloading;
            this.Export.Name = "Export";
            this.Export.TabStop = false;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Import
            // 
            resources.ApplyResources(this.Import, "Import");
            this.Import.Image = global::K2Lin_Crypto.Properties.Resources.upload;
            this.Import.Name = "Import";
            this.Import.TabStop = false;
            this.Import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Keypairs
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TFAPassword);
            this.Controls.Add(this.lblTFA);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.lblEncryptNote);
            this.Controls.Add(this.lblKeyFile);
            this.Controls.Add(this.lblSessionID);
            this.Controls.Add(this.SessionID);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.lblSelectLength);
            this.Controls.Add(this.Sel8192);
            this.Controls.Add(this.Sel4096);
            this.Controls.Add(this.Sel2048);
            this.Controls.Add(this.privkey);
            this.Controls.Add(this.pubkey);
            this.Controls.Add(this.lblPrivKey);
            this.Controls.Add(this.lblPubKey);
            this.Name = "Keypairs";
            this.Load += new System.EventHandler(this.Keypairs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Import)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPubKey;
        private System.Windows.Forms.Label lblPrivKey;
        private System.Windows.Forms.TextBox pubkey;
        private System.Windows.Forms.TextBox privkey;
        private System.Windows.Forms.RadioButton Sel2048;
        private System.Windows.Forms.RadioButton Sel4096;
        private System.Windows.Forms.RadioButton Sel8192;
        private System.Windows.Forms.Label lblSelectLength;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox SessionID;
        private System.Windows.Forms.Label lblSessionID;
        private System.Windows.Forms.SaveFileDialog SaveXML;
        private System.Windows.Forms.OpenFileDialog ReadXML;
        private System.Windows.Forms.Label lblKeyFile;
        private System.Windows.Forms.Label lblEncryptNote;
        private System.Windows.Forms.PictureBox Import;
        private System.Windows.Forms.PictureBox Export;
        private System.Windows.Forms.Label lblTFA;
        private System.Windows.Forms.TextBox TFAPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}