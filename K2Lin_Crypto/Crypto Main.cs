using K2Lin_Crypto.Forms;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace K2Lin_Crypto
{
    public partial class CryptoMain : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();
        private PrivateFontCollection fontsCN = new PrivateFontCollection();

        public static Font Eng_Comfortaa;
        public static Font Eng_ComfortaaHighlight;
        public static Font CN_waresu;
        public static string PubKey;
        public static string PrivKey;
        public static string SessionID;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public CryptoMain()
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(2048);
            csp.PersistKeyInCsp = false;
            string publickey = csp.ToXmlString(false);
            string privatekey = csp.ToXmlString(true);
            XmlDocument PublicKeyXML = new XmlDocument();
            PublicKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement PubText = PublicKeyXML.CreateElement("PublicKey");
            PubText.InnerText = publickey;
            PublicKeyXML.DocumentElement.AppendChild(PubText);
            PubKey = PublicKeyXML.OuterXml;
            XmlDocument PrivateKeyXML = new XmlDocument();
            PrivateKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement PrivText = PrivateKeyXML.CreateElement("PrivateKey");
            PrivText.InnerText = privatekey;
            PrivateKeyXML.DocumentElement.AppendChild(PrivText);
            PrivKey = PrivateKeyXML.OuterXml;
            XmlDocument PublicKey = new XmlDocument();
            PublicKey.LoadXml(PublicKeyXML.OuterXml);
            string pubkeypath = "K2LinCrypto/PublicKey";
            string PubKeyXMLformat = PublicKey.SelectSingleNode(pubkeypath).InnerText;
            SessionID = Math.Abs(PubKeyXMLformat.GetHashCode()).ToString();
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            random = new Random();
            LoadFonts();
            buttonMainmenu.Font = Eng_Comfortaa;
            buttonDcryption.Font = Eng_Comfortaa;
            buttonEncryption.Font = Eng_Comfortaa;
            buttonKeypairs.Font = Eng_Comfortaa;
            buttonKeypairs.Font = Eng_Comfortaa;
            buttonAbout.Font = Eng_Comfortaa;
            lblTitle.Font = Eng_Comfortaa;
            OpenChildForm(new Forms.Mainmenu(), buttonMainmenu);
        }

        //Methods
        private void LoadFonts()
        {
            byte[] fontData = Properties.Resources.Comfortaa;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Comfortaa.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Comfortaa.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            Eng_Comfortaa = new Font(fonts.Families[0], 16.0F);
            Eng_ComfortaaHighlight = new Font(fonts.Families[0], 20.0F);

            byte[] fontDataCN = Properties.Resources.waresu;
            IntPtr fontPtrCN = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontDataCN.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontDataCN, 0, fontPtrCN, fontDataCN.Length);
            uint dummyCN = 0;
            fontsCN.AddMemoryFont(fontPtrCN, Properties.Resources.waresu.Length);
            AddFontMemResourceEx(fontPtrCN, (uint)Properties.Resources.waresu.Length, IntPtr.Zero, ref dummyCN);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtrCN);

            CN_waresu = new Font(fontsCN.Families[0], 16.0F);
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = Eng_ComfortaaHighlight;
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = Eng_Comfortaa;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void buttonMainmenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Mainmenu(), sender);
        }

        private void buttonDcryption_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Decryption(), sender);
        }

        private void buttonEncryption_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Encryption(), sender);
        }

        private void buttonKeypairs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Keypairs(), sender);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.About(), sender);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
