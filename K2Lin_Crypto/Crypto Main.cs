using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin;
using MaterialSkin.Controls;

namespace K2Lin_Crypto
{
    public partial class CryptoMain : MaterialForm
    {
        //Fields
        private Random random;
        private Form activeForm;
        private Dictionary<TabPage, Form> formCache = new Dictionary<TabPage, Form>();

        public static string PubKey;
        public static string PrivKey;
        public static string SessionID;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public CryptoMain()
        {
            GenerateNewKey();
            DetectLanguage();
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            random = new Random();
            materialTabControl1.SelectedIndexChanged += new EventHandler(materialTabControl1_SelectedIndexChanged);
            OpenChildForm(new Forms.Mainmenu(), materialTabControl1.TabPages[0]);
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = materialTabControl1.SelectedTab.Text;
            if (formCache.ContainsKey(materialTabControl1.SelectedTab))
            {
                OpenChildForm(formCache[materialTabControl1.SelectedTab], materialTabControl1.SelectedTab);
            }
            else
            {
                switch (materialTabControl1.SelectedTab.Name)
                {
                    case "tabPage1":
                        OpenChildForm(new Forms.Mainmenu(), materialTabControl1.SelectedTab);
                        break;
                    case "tabPage2":
                        OpenChildForm(new Forms.Encryption(), materialTabControl1.SelectedTab);
                        break;
                    case "tabPage3":
                        OpenChildForm(new Forms.Decryption(), materialTabControl1.SelectedTab);
                        break;
                    case "tabPage4":
                        OpenChildForm(new Forms.Keypairs(), materialTabControl1.SelectedTab);
                        break;
                    case "tabPage5":
                        OpenChildForm(new Forms.StegoEncrypt(), materialTabControl1.SelectedTab);
                        break;
                    case "tabPage6":
                        OpenChildForm(new Forms.StegoDecrypt(), materialTabControl1.SelectedTab);
                        break;
                    case "tabPage7":
                        OpenChildForm(new Forms.About(), materialTabControl1.SelectedTab);
                        break;
                }
            }
        }

        private static void DetectLanguage()
        {
            string localLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (localLanguage.Contains("zh"))
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("");
            }
        }

        private static void GenerateNewKey()
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
        }

        private void OpenChildForm(Form childForm, TabPage tabPage)
        {
            if (activeForm != null && activeForm != childForm)
                activeForm.Hide();

            activeForm = childForm;

            if (!formCache.ContainsKey(tabPage))
            {
                formCache.Add(tabPage, childForm);
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                tabPage.Controls.Add(childForm);
            }

            childForm.BringToFront();
            childForm.Show();
        }

    }
}
