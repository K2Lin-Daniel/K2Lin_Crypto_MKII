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
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
            lblReciverPubKey.Font = CryptoMain.Eng_Comfortaa;
            lblSessionID.Font = CryptoMain.Eng_Comfortaa;
            EncryptSessionID.Font = CryptoMain.Eng_Comfortaa;
            lblTextEncrypt.Font = CryptoMain.Eng_Comfortaa;
            lblCiperText.Font = CryptoMain.Eng_Comfortaa;
            ReceiverPublic.Font = CryptoMain.CN_waresu;
            EncryptoText.Font = CryptoMain.CN_waresu;
            EncryptButton.Font = CryptoMain.Eng_Comfortaa;
            EncryptoResult.Font = CryptoMain.CN_waresu;
            CopyEncryptedText.Font = CryptoMain.Eng_Comfortaa;
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
                byte[] encryptedtext = rsa.Encrypt(data, false);
                XmlDocument EncryptXML = new XmlDocument();
                EncryptXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                XmlElement Text = EncryptXML.CreateElement("EncryptedText");
                Text.InnerText = Convert.ToBase64String(encryptedtext);
                EncryptXML.DocumentElement.AppendChild(Text);
                XmlElement HashID = EncryptXML.CreateElement("HashID");
                HashID.InnerText = EncryptSessionID.Text;
                EncryptXML.DocumentElement.AppendChild(HashID);
                EncryptoResult.Text = EncryptXML.OuterXml;
            }
            catch (Exception error)
            {
                MessageBox.Show("发现错误了！" + error + " 加密失败", "K2Lin Crypto (ﾟДﾟ*)ﾉ", MessageBoxButtons.OK);
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

        private void EncryptoResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
