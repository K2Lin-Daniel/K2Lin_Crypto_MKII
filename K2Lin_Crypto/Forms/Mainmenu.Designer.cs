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
            this.Welcome = new MaterialSkin.Controls.MaterialLabel();
            this.tips = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            //
            // Welcome
            //
            this.Welcome.Depth = 0;
            this.Welcome.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Welcome.Location = new System.Drawing.Point(12, 9);
            this.Welcome.MouseState = MaterialSkin.MouseState.HOVER;
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(260, 23);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome to K2Lin Crypto!";
            //
            // tips
            //
            this.tips.Depth = 0;
            this.tips.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tips.Location = new System.Drawing.Point(12, 41);
            this.tips.MouseState = MaterialSkin.MouseState.HOVER;
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(260, 23);
            this.tips.TabIndex = 1;
            this.tips.Text = "Select a function from the tabs above.";
            //
            // Mainmenu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.Welcome);
            this.Name = "Mainmenu";
            this.Text = "Mainmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel Welcome;
        private MaterialSkin.Controls.MaterialLabel tips;
    }
}
