using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2Lin_Crypto.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            label1.Font = CryptoMain.Eng_Comfortaa;
            button1.Font = CryptoMain.Eng_Comfortaa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/K2Lin-Daniel");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
