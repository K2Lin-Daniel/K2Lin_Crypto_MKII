using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K2Lin_Crypto.Forms
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                Welcome.Font = CryptoMain.zhHans_waresuHighlight;
                tips.Font = CryptoMain.zhHans_waresu;
            }
            else
            {
                Welcome.Font = CryptoMain.Eng_ComfortaaHighlight;
                tips.Font = CryptoMain.Eng_Comfortaa;
            }
        }
    }
}
