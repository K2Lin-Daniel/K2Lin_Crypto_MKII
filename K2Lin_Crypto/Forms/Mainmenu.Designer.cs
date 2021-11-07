namespace K2Lin_Crypto.Forms
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.Welcome = new System.Windows.Forms.Label();
            this.tips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            resources.ApplyResources(this.Welcome, "Welcome");
            this.Welcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.Welcome.Name = "Welcome";
            // 
            // tips
            // 
            resources.ApplyResources(this.tips, "tips");
            this.tips.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.tips.Name = "tips";
            // 
            // Mainmenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tips);
            this.Controls.Add(this.Welcome);
            this.Name = "Mainmenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label tips;
    }
}