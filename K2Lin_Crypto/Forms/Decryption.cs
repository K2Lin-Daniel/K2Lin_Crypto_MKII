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
    public partial class Decryption : Form
    {
        string pubkey = CryptoMain.PubKey;
        string privkey = CryptoMain.PrivKey;
        public Decryption()
        {
            InitializeComponent();
            SessionID.Text = CryptoMain.SessionID;
            SessionID.Font = CryptoMain.Eng_Comfortaa;
            lblSessionID.Font = CryptoMain.Eng_Comfortaa;
            lblDecryptedText.Font = CryptoMain.Eng_ComfortaaHighlight;
            lblTextDecrypt.Font = CryptoMain.Eng_ComfortaaHighlight;
            CopyPublicKey.Font = CryptoMain.Eng_Comfortaa;
            CopyDecryptedText.Font = CryptoMain.Eng_Comfortaa;
            DecryptButton.Font = CryptoMain.Eng_Comfortaa;
            DecryptoResult.Font = CryptoMain.CN_waresu;
            DecryptoText.Font = CryptoMain.CN_waresu;
            SessionIDIncorrect.Font = CryptoMain.Eng_Comfortaa;
        }

        private void CopyPublicKey_Click(object sender, EventArgs e)
        {
                Clipboard.SetData(DataFormats.Text, (Object)pubkey);
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument DecryptXML = new XmlDocument();
                DecryptXML.LoadXml(DecryptoText.Text);
                string textpath = "K2LinCrypto/EncryptedText";
                string DecryptText = DecryptXML.SelectSingleNode(textpath).InnerText;
                string hashpath = "K2LinCrypto/HashID";
                string HashID = DecryptXML.SelectSingleNode(hashpath).InnerText;
                if (HashID != SessionID.Text)
                {
                    SessionIDIncorrect.Visible = true;
                    return;
                }
                else
                {
                    SessionIDIncorrect.Visible = false;
                }
                XmlDocument PrivateKeyXML = new XmlDocument();
                PrivateKeyXML.LoadXml(privkey);
                string privkeypath = "K2LinCrypto/PrivateKey";
                string Privkey = PrivateKeyXML.SelectSingleNode(privkeypath).InnerText;
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.FromXmlString(Privkey);
                byte[] Encryptedtext = Convert.FromBase64String(DecryptText);
                byte[] decryptedtext = rsa.Decrypt(Encryptedtext, false);
                DecryptoResult.Text = Encoding.UTF8.GetString(decryptedtext);
            }
            catch (Exception error)
            {
                MessageBox.Show("发现错误了！" + error + " 解密失败", "K2Lin Crypto (ﾟДﾟ*)ﾉ", MessageBoxButtons.OK);
            }
        }

        private void CopyDecryptedText_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)DecryptoResult.Text);
        }
    }
}
