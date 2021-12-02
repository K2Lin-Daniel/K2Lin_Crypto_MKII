using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace K2Lin_Crypto.Forms
{
    public partial class AESEncrypt : Form
    {
        public AESEncrypt()
        {
            InitializeComponent();
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                lblOriginText.Font = CryptoMain.zhHans_waresu;
                lblPassKey.Font = CryptoMain.zhHans_waresu;
                lblSessionID.Font = CryptoMain.zhHans_waresu;
                OriginText.Font = CryptoMain.zhHans_waresu;
                CryptButton.Font = CryptoMain.zhHans_waresu;
                ResultText.Font = CryptoMain.zhHans_waresu;
                KeyID.Font = CryptoMain.zhHans_waresu;
                CopyDecryptedText.Font = CryptoMain.zhHans_waresu;
                GenerateKey.Font = CryptoMain.zhHans_waresu;
            }
            else
            {
                lblOriginText.Font = CryptoMain.Eng_Comfortaa;
                lblPassKey.Font = CryptoMain.Eng_Comfortaa;
                lblSessionID.Font = CryptoMain.Eng_Comfortaa;
                OriginText.Font = CryptoMain.Eng_Comfortaa;
                CryptButton.Font = CryptoMain.Eng_Comfortaa;
                ResultText.Font = CryptoMain.Eng_Comfortaa;
                KeyID.Font = CryptoMain.Eng_Comfortaa;
                CopyDecryptedText.Font = CryptoMain.Eng_Comfortaa;
                GenerateKey.Font = CryptoMain.Eng_Comfortaa;
            }
        }

        private void AESEncrypt_Load(object sender, EventArgs e)
        {

        }

        private void PassKey_TextChanged(object sender, EventArgs e)
        {
            KeyID.Text = Math.Abs(PassKey.Text.GetHashCode()).ToString();
        }

        private void CryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OriginText.Text.Contains("<AES-EncryptedText>"))
                {
                    XmlDocument TextXML = new XmlDocument();
                    TextXML.LoadXml(OriginText.Text);
                    string EncryptedTextpath = "K2LinCrypto/AES-EncryptedText";
                    string EncryptedText = TextXML.SelectSingleNode(EncryptedTextpath).InnerText;
                    string saltpath = "K2LinCrypto/Salt";
                    string Saltbyte = TextXML.SelectSingleNode(saltpath).InnerText;
                    byte[] Salt = Convert.FromBase64String(Saltbyte);
                    ResultText.Text = AES.Decrypt(EncryptedText, Encoding.UTF8.GetString(AES.PBKDF2Hash(PassKey.Text, Salt)));
                }
                else
                {
                    byte[] Salt = new byte[128 / 8];
                    using (var rng = RandomNumberGenerator.Create())
                    {
                        rng.GetBytes(Salt);
                    }
                    string EncryptedTextString = AES.Encrypt(OriginText.Text, Encoding.UTF8.GetString(AES.PBKDF2Hash(PassKey.Text, Salt)));
                    XmlDocument EncryptXML = new XmlDocument();
                    EncryptXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                    XmlElement EncryptedText = EncryptXML.CreateElement("AES-EncryptedText");
                    EncryptedText.InnerText = EncryptedTextString;
                    EncryptXML.DocumentElement.AppendChild(EncryptedText);
                    XmlElement AntiCrackSalt = EncryptXML.CreateElement("Salt");
                    AntiCrackSalt.InnerText = Convert.ToBase64String(Salt);
                    EncryptXML.DocumentElement.AppendChild(AntiCrackSalt);
                    ResultText.Text = EncryptXML.OuterXml;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("发现错误了！" + error + " 处理失败", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
            }
        }

        private void CopyDecryptedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)ResultText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] KeyByte = new byte[256];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(KeyByte);
            }
            Clipboard.SetData(DataFormats.Text, (Object)Convert.ToBase64String(KeyByte));
        }
    }
}
