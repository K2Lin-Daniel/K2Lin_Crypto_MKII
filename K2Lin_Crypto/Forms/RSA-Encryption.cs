using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace K2Lin_Crypto.Forms
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
            lblReciverPubKey.Font = CryptoMain.HuninnFont;
            lblSessionID.Font = CryptoMain.HuninnFont;
            EncryptSessionID.Font = CryptoMain.HuninnFont;
            lblTextEncrypt.Font = CryptoMain.HuninnFontHighlight;
            lblCiperText.Font = CryptoMain.HuninnFontHighlight;
            ReceiverPublic.Font = CryptoMain.HuninnFont;
            EncryptoText.Font = CryptoMain.HuninnFont;
            EncryptButton.Font = CryptoMain.HuninnFont;
            EncryptoResult.Font = CryptoMain.HuninnFont;
            CopyEncryptedText.Font = CryptoMain.HuninnFont;
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                XmlDocument PublicKeyXML = new XmlDocument();
                PublicKeyXML.LoadXml(ReceiverPublic.Text);
                string pubkeypath = "K2LinCrypto/PublicKey";
                string ReceiverPubkey = PublicKeyXML.SelectSingleNode(pubkeypath).InnerText;
                rsa.FromXmlString(ReceiverPubkey);
                byte[] data = Encoding.UTF8.GetBytes(EncryptoText.Text);
                byte[] encryptedtext = rsa.Encrypt(data, true);
                XmlDocument EncryptXML = new XmlDocument();
                EncryptXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                XmlElement Text = EncryptXML.CreateElement("RSA-EncryptedText");
                Text.InnerText = Convert.ToBase64String(encryptedtext);
                EncryptXML.DocumentElement.AppendChild(Text);
                XmlElement HashID = EncryptXML.CreateElement("HashID");
                HashID.InnerText = EncryptSessionID.Text;
                EncryptXML.DocumentElement.AppendChild(HashID);
                EncryptoResult.Text = EncryptXML.OuterXml;
            }
            catch (Exception error)
            {
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    MessageBox.Show("发现错误了！" + error + " 加密失败", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Encountered an error！" + error + " Encryption failed", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
            }
        }

        private void ReceiverPublic_TextChanged(object sender, EventArgs e)
        {
            try
            {
                XmlDocument PublicKeyXML = new XmlDocument();
                PublicKeyXML.LoadXml(ReceiverPublic.Text);
                string pubkeypath = "K2LinCrypto/PublicKey";
                string ReceiverPubkey = PublicKeyXML.SelectSingleNode(pubkeypath).InnerText;
                EncryptSessionID.Text = Math.Abs(ReceiverPubkey.GetHashCode()).ToString();
            }
            catch (Exception)
            {
            }
        }

        private void CopyEncryptedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)EncryptoResult.Text);
        }
    }
}
