namespace K2Lin_Crypto
{
    partial class CryptoMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonPNGStegano = new System.Windows.Forms.Button();
            this.buttonAESEncrypt = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonKeypairs = new System.Windows.Forms.Button();
            this.buttonDecryption = new System.Windows.Forms.Button();
            this.buttonEncryption = new System.Windows.Forms.Button();
            this.buttonMainmenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.minimizebtn = new System.Windows.Forms.PictureBox();
            this.maximizebtn = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.buttonPNGStegano);
            this.panelMenu.Controls.Add(this.buttonAESEncrypt);
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Controls.Add(this.buttonKeypairs);
            this.panelMenu.Controls.Add(this.buttonDecryption);
            this.panelMenu.Controls.Add(this.buttonEncryption);
            this.panelMenu.Controls.Add(this.buttonMainmenu);
            this.panelMenu.Controls.Add(this.panelLogo);
            resources.ApplyResources(this.panelMenu, "panelMenu");
            this.panelMenu.Name = "panelMenu";
            // 
            // buttonPNGStegano
            // 
            resources.ApplyResources(this.buttonPNGStegano, "buttonPNGStegano");
            this.buttonPNGStegano.FlatAppearance.BorderSize = 0;
            this.buttonPNGStegano.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonPNGStegano.Name = "buttonPNGStegano";
            this.buttonPNGStegano.UseVisualStyleBackColor = true;
            this.buttonPNGStegano.Click += new System.EventHandler(this.buttonPNGStegano_Click);
            // 
            // buttonAESEncrypt
            // 
            resources.ApplyResources(this.buttonAESEncrypt, "buttonAESEncrypt");
            this.buttonAESEncrypt.FlatAppearance.BorderSize = 0;
            this.buttonAESEncrypt.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonAESEncrypt.Name = "buttonAESEncrypt";
            this.buttonAESEncrypt.UseVisualStyleBackColor = true;
            this.buttonAESEncrypt.Click += new System.EventHandler(this.AESEncrypt_Click);
            // 
            // buttonAbout
            // 
            resources.ApplyResources(this.buttonAbout, "buttonAbout");
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonAbout.Image = global::K2Lin_Crypto.Properties.Resources.book;
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonKeypairs
            // 
            resources.ApplyResources(this.buttonKeypairs, "buttonKeypairs");
            this.buttonKeypairs.FlatAppearance.BorderSize = 0;
            this.buttonKeypairs.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonKeypairs.Image = global::K2Lin_Crypto.Properties.Resources.box;
            this.buttonKeypairs.Name = "buttonKeypairs";
            this.buttonKeypairs.UseVisualStyleBackColor = true;
            this.buttonKeypairs.Click += new System.EventHandler(this.buttonKeypairs_Click);
            // 
            // buttonDecryption
            // 
            resources.ApplyResources(this.buttonDecryption, "buttonDecryption");
            this.buttonDecryption.FlatAppearance.BorderSize = 0;
            this.buttonDecryption.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonDecryption.Image = global::K2Lin_Crypto.Properties.Resources.key;
            this.buttonDecryption.Name = "buttonDecryption";
            this.buttonDecryption.UseVisualStyleBackColor = true;
            this.buttonDecryption.Click += new System.EventHandler(this.buttonDecryption_Click);
            // 
            // buttonEncryption
            // 
            resources.ApplyResources(this.buttonEncryption, "buttonEncryption");
            this.buttonEncryption.FlatAppearance.BorderSize = 0;
            this.buttonEncryption.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonEncryption.Image = global::K2Lin_Crypto.Properties.Resources.padlock;
            this.buttonEncryption.Name = "buttonEncryption";
            this.buttonEncryption.UseVisualStyleBackColor = true;
            this.buttonEncryption.Click += new System.EventHandler(this.buttonEncryption_Click);
            // 
            // buttonMainmenu
            // 
            resources.ApplyResources(this.buttonMainmenu, "buttonMainmenu");
            this.buttonMainmenu.FlatAppearance.BorderSize = 0;
            this.buttonMainmenu.ForeColor = System.Drawing.Color.Honeydew;
            this.buttonMainmenu.Image = global::K2Lin_Crypto.Properties.Resources.home;
            this.buttonMainmenu.Name = "buttonMainmenu";
            this.buttonMainmenu.UseVisualStyleBackColor = true;
            this.buttonMainmenu.Click += new System.EventHandler(this.buttonMainmenu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLogo.BackgroundImage = global::K2Lin_Crypto.Properties.Resources.Crypto_Logo_Small_Ver3;
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.CadetBlue;
            this.panelTitleBar.Controls.Add(this.minimizebtn);
            this.panelTitleBar.Controls.Add(this.maximizebtn);
            this.panelTitleBar.Controls.Add(this.closebtn);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.panelTitleBar, "panelTitleBar");
            this.panelTitleBar.ForeColor = System.Drawing.Color.Black;
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // minimizebtn
            // 
            resources.ApplyResources(this.minimizebtn, "minimizebtn");
            this.minimizebtn.Image = global::K2Lin_Crypto.Properties.Resources.minimize_window_32;
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.TabStop = false;
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // maximizebtn
            // 
            resources.ApplyResources(this.maximizebtn, "maximizebtn");
            this.maximizebtn.Image = global::K2Lin_Crypto.Properties.Resources.maximize_window_32;
            this.maximizebtn.Name = "maximizebtn";
            this.maximizebtn.TabStop = false;
            this.maximizebtn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // closebtn
            // 
            resources.ApplyResources(this.closebtn, "closebtn");
            this.closebtn.Image = global::K2Lin_Crypto.Properties.Resources.close_window_32;
            this.closebtn.Name = "closebtn";
            this.closebtn.TabStop = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Name = "lblTitle";
            // 
            // panelDesktopPane
            // 
            resources.ApplyResources(this.panelDesktopPane, "panelDesktopPane");
            this.panelDesktopPane.Name = "panelDesktopPane";
            // 
            // CryptoMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "CryptoMain";
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMainmenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonKeypairs;
        private System.Windows.Forms.Button buttonDecryption;
        private System.Windows.Forms.Button buttonEncryption;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox closebtn;
        private System.Windows.Forms.PictureBox maximizebtn;
        private System.Windows.Forms.PictureBox minimizebtn;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button buttonAESEncrypt;
        private System.Windows.Forms.Button buttonPNGStegano;
    }
}

