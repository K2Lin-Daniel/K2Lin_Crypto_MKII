namespace K2Lin_Crypto.Forms
{
    partial class PNGSteganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PNGSteganography));
            this.ReadPNG = new System.Windows.Forms.OpenFileDialog();
            this.SavePNG = new System.Windows.Forms.SaveFileDialog();
            this.ReadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.LocationBox = new System.Windows.Forms.TextBox();
            this.PNGPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PNGPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadPNG
            // 
            this.ReadPNG.FileName = "openFileDialog1";
            // 
            // ReadButton
            // 
            resources.ApplyResources(this.ReadButton, "ReadButton");
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.UseVisualStyleBackColor = true;
            this.ReadButton.Click += new System.EventHandler(this.ReadButton_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EncryptButton
            // 
            resources.ApplyResources(this.EncryptButton, "EncryptButton");
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // TextBox
            // 
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.Name = "TextBox";
            // 
            // DecryptButton
            // 
            resources.ApplyResources(this.DecryptButton, "DecryptButton");
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // LocationBox
            // 
            resources.ApplyResources(this.LocationBox, "LocationBox");
            this.LocationBox.Name = "LocationBox";
            this.LocationBox.ReadOnly = true;
            // 
            // PNGPreview
            // 
            resources.ApplyResources(this.PNGPreview, "PNGPreview");
            this.PNGPreview.Name = "PNGPreview";
            this.PNGPreview.TabStop = false;
            this.PNGPreview.DoubleClick += new System.EventHandler(this.PNGPreview_DoubleClick);
            this.PNGPreview.MouseEnter += new System.EventHandler(this.PNGPreview_MouseEnter);
            this.PNGPreview.MouseLeave += new System.EventHandler(this.PNGPreview_MouseLeave);
            this.PNGPreview.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PNGPreview_PreviewKeyDown);
            // 
            // PNGSteganography
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocationBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.PNGPreview);
            this.Name = "PNGSteganography";
            ((System.ComponentModel.ISupportInitialize)(this.PNGPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PNGPreview;
        private System.Windows.Forms.OpenFileDialog ReadPNG;
        private System.Windows.Forms.SaveFileDialog SavePNG;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.TextBox LocationBox;
    }
}