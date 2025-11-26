using System;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace K2Lin_Crypto.Forms
{
    public partial class Keypairs : Form
    {
        int dwKeySize = 2048;
        public Keypairs()
        {
            InitializeComponent();
            pubkey.Text = CryptoMain.PubKey;
            privkey.Text = CryptoMain.PrivKey;
            SessionID.Text = CryptoMain.SessionID;
            lblPrivKey.Font = CryptoMain.HuninnFont;
            lblPubKey.Font = CryptoMain.HuninnFont;
            lblSessionID.Font = CryptoMain.HuninnFont;
            lblSelectLength.Font = CryptoMain.HuninnFont;
            lblEncryptNote.Font = CryptoMain.HuninnFont;
            lblKeyFile.Font = CryptoMain.HuninnFontHighlight;
            lblTFA.Font = CryptoMain.HuninnFont;
            TFAPassword.Font = CryptoMain.HuninnFont;
            SessionID.Font = CryptoMain.HuninnFont;
            generate.Font = CryptoMain.HuninnFont;
        }

        private void Keypairs_Load(object sender, EventArgs e)
        {

        }

        private void Sel2048_CheckedChanged(object sender, EventArgs e)
        {
            dwKeySize = 2048;
        }
        private void Sel4096_CheckedChanged(object sender, EventArgs e)
        {
            dwKeySize = 4096;
        }
        private void Sel8192_CheckedChanged(object sender, EventArgs e)
        {
            dwKeySize = 8192;
        }

        private void generate_Click(object sender, EventArgs e)
        {
            GenerateNew();
        }

        private void GenerateNew()
        {
            RSACryptoServiceProvider csp = new RSACryptoServiceProvider(dwKeySize);
            csp.PersistKeyInCsp = false;
            string publickey = csp.ToXmlString(false);
            string privatekey = csp.ToXmlString(true);
            XmlDocument PublicKeyXML = new XmlDocument();
            PublicKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement PubText = PublicKeyXML.CreateElement("PublicKey");
            PubText.InnerText = publickey;
            PublicKeyXML.DocumentElement.AppendChild(PubText);
            pubkey.Text = PublicKeyXML.OuterXml;
            CryptoMain.PubKey = PublicKeyXML.OuterXml;
            XmlDocument PrivateKeyXML = new XmlDocument();
            PrivateKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
            XmlElement PrivText = PrivateKeyXML.CreateElement("PrivateKey");
            PrivText.InnerText = privatekey;
            PrivateKeyXML.DocumentElement.AppendChild(PrivText);
            privkey.Text = PrivateKeyXML.OuterXml;
            CryptoMain.PrivKey = PrivateKeyXML.OuterXml;
            XmlDocument PublicKey = new XmlDocument();
            PublicKey.LoadXml(PublicKeyXML.OuterXml);
            string pubkeypath = "K2LinCrypto/PublicKey";
            string PubKeyXMLformat = PublicKey.SelectSingleNode(pubkeypath).InnerText;
            SessionID.Text = Math.Abs(PubKeyXMLformat.GetHashCode()).ToString();
            CryptoMain.SessionID = Math.Abs(PubKeyXMLformat.GetHashCode()).ToString();
        }

        Func<string> SystemId = () =>
        {
            try
            {
                ManagementObjectCollection mbsList = null;
                ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
                mbsList = mbs.Get();
                string id = "";
                foreach (ManagementObject mo in mbsList)
                {
                    id = mo["ProcessorID"].ToString();
                }

                ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                ManagementObjectCollection moc = mos.Get();
                string motherBoard = "";
                foreach (ManagementObject mo in moc)
                {
                    motherBoard = (string)mo["SerialNumber"];
                }

                string uniqueSystemId = id + motherBoard;
                return AES.sha256(uniqueSystemId);
            }
            catch (Exception error)
            {
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    MessageBox.Show("发现错误了！" + error + " 读取SystemID失败", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Encountered an error！" + error + " Can't Read SystemID", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
                return null;
            }
        };

        private void Export_Click(object sender, EventArgs e)
        {
            SaveToXML(privkey.Text, pubkey.Text);
        }

        private void SaveToXML(string Privtext, string Pubtext)
        {
            Stream SaveXML_Stream;
            SaveXML.Filter = "XML (*.xml)|*.xml";
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                SaveXML.Title = "请选择XML文件以保存密钥对.";
                SaveXML.Filter = "XML 密钥对文件 (*.xml)|*.xml";
            }
            else
            {
                SaveXML.Title = "Please select an XML file to save the key pair.";
                SaveXML.Filter = "XML Keypair File (*.xml)|*.xml";
            }


            if (SaveXML.ShowDialog() == DialogResult.OK)
            {
                if ((SaveXML_Stream = SaveXML.OpenFile()) != null)
                {
                    try
                    {
                        // Code to write the stream goes here.
                        XmlDocument PublicKeyXML = new XmlDocument();
                        PublicKeyXML.LoadXml(Pubtext);
                        string pubkeypath = "K2LinCrypto/PublicKey";
                        string Pubkey = PublicKeyXML.SelectSingleNode(pubkeypath).InnerText;
                        XmlDocument PrivateKeyXML = new XmlDocument();
                        PrivateKeyXML.LoadXml(Privtext);
                        string privkeypath = "K2LinCrypto/PrivateKey";
                        string Privkey = PrivateKeyXML.SelectSingleNode(privkeypath).InnerText;
                        string Systemid = SystemId();
                        byte[] Salt = new byte[128 / 8];
                        using (var rng = RandomNumberGenerator.Create())
                        {
                            rng.GetBytes(Salt);
                        }
                        string PrivkeyEncrypted = AES.Encrypt(Privkey, Encoding.UTF8.GetString(AES.PBKDF2Hash(Systemid + TFAPassword.Text, Salt)));
                        string PubkeyEncrypted = AES.Encrypt(Pubkey, Encoding.UTF8.GetString(AES.PBKDF2Hash(Systemid + TFAPassword.Text, Salt)));
                        XmlDocument SaveKeyPairXML = new XmlDocument();
                        SaveKeyPairXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                        XmlElement HashID = SaveKeyPairXML.CreateElement("HashID");
                        HashID.InnerText = Math.Abs(Pubkey.GetHashCode()).ToString();
                        SaveKeyPairXML.DocumentElement.AppendChild(HashID);
                        XmlElement PubText = SaveKeyPairXML.CreateElement("ExtractedPublicKey");
                        PubText.InnerText = PubkeyEncrypted;
                        SaveKeyPairXML.DocumentElement.AppendChild(PubText);
                        XmlElement PrivText = SaveKeyPairXML.CreateElement("ExtractedPrivateKey");
                        PrivText.InnerText = PrivkeyEncrypted;
                        SaveKeyPairXML.DocumentElement.AppendChild(PrivText);
                        XmlElement AntiCrackSalt = SaveKeyPairXML.CreateElement("Salt");
                        AntiCrackSalt.InnerText = Convert.ToBase64String(Salt);
                        SaveKeyPairXML.DocumentElement.AppendChild(AntiCrackSalt);
                        if (TFAPassword.Text != "")
                        {
                            XmlElement TFALabel = SaveKeyPairXML.CreateElement("Two_Factor_Auth");
                            TFALabel.InnerText = "true";
                            SaveKeyPairXML.DocumentElement.AppendChild(TFALabel);
                        }
                        else
                        {
                            XmlElement TFALabel = SaveKeyPairXML.CreateElement("Two_Factor_Auth");
                            TFALabel.InnerText = "false";
                            SaveKeyPairXML.DocumentElement.AppendChild(TFALabel);
                        }
                        SaveKeyPairXML.Save(SaveXML_Stream);
                        SaveXML_Stream.Close();
                    }
                    catch (Exception error)
                    {
                        if (selLanguage.Contains("zh"))
                        {
                            MessageBox.Show("发现错误了！" + error + " 保存失败", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Encountered an error！" + error + " Save failed", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;
                ReadXML.Filter = "XML (*.xml)|*.xml";
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    ReadXML.Title = "请选择XML文件以读取密钥对.";
                }
                else
                {
                    ReadXML.Title = "Please select an XML file to read the key pair.";
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //Get the path of specified file
                        filePath = openFileDialog.FileName;

                        //Read the contents of the file into a stream
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader reader = new StreamReader(fileStream))
                        {
                            fileContent = reader.ReadToEnd();
                            XmlDocument ReadKeyPairXML = new XmlDocument();
                            ReadKeyPairXML.LoadXml(fileContent);
                            string saltpath = "K2LinCrypto/Salt";
                            string Saltbyte = ReadKeyPairXML.SelectSingleNode(saltpath).InnerText;
                            byte[] Salt = Convert.FromBase64String(Saltbyte);
                            string pubkeypath = "K2LinCrypto/ExtractedPublicKey";
                            string Pubkey = ReadKeyPairXML.SelectSingleNode(pubkeypath).InnerText;
                            string privkeypath = "K2LinCrypto/ExtractedPrivateKey";
                            string Privkey = ReadKeyPairXML.SelectSingleNode(privkeypath).InnerText;
                            string Systemid = SystemId();
                            string DecryptedPubkey = AES.Decrypt(Pubkey, Encoding.UTF8.GetString(AES.PBKDF2Hash(Systemid + TFAPassword.Text, Salt)));
                            string DecryptedPrivkey = AES.Decrypt(Privkey, Encoding.UTF8.GetString(AES.PBKDF2Hash(Systemid + TFAPassword.Text, Salt)));
                            string HashIDpath = "K2LinCrypto/HashID";
                            string HashID = ReadKeyPairXML.SelectSingleNode(HashIDpath).InnerText;
                            XmlDocument PublicKeyXML = new XmlDocument();
                            PublicKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                            XmlElement PubText = PublicKeyXML.CreateElement("PublicKey");
                            PubText.InnerText = DecryptedPubkey;
                            PublicKeyXML.DocumentElement.AppendChild(PubText);
                            XmlDocument PrivateKeyXML = new XmlDocument();
                            PrivateKeyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                            XmlElement PrivText = PrivateKeyXML.CreateElement("PrivateKey");
                            PrivText.InnerText = DecryptedPrivkey;
                            PrivateKeyXML.DocumentElement.AppendChild(PrivText);
                            XmlDocument PublicKey = new XmlDocument();
                            PublicKey.LoadXml(PublicKeyXML.OuterXml);
                            string pubkeyxmlpath = "K2LinCrypto/PublicKey";
                            string PubKeyXMLformat = PublicKey.SelectSingleNode(pubkeyxmlpath).InnerText;
                            string TFALabelpath = "K2LinCrypto/Two_Factor_Auth";
                            string TFALabel = ReadKeyPairXML.SelectSingleNode(TFALabelpath).InnerText;
                            if (HashID == Math.Abs(PubKeyXMLformat.GetHashCode()).ToString())
                            {
                                if (selLanguage.Contains("zh"))
                                {
                                    MessageBox.Show("密钥对序列号:" + HashID + " 的密钥对导入成功", "密钥对数据读取成功 ヾ(≧▽≦*)o", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("SessionID:" + HashID + " The key pair is imported successfully", "Key pair data read successfully ヾ(≧▽≦*)o", MessageBoxButtons.OK);
                                }

                                privkey.Text = PrivateKeyXML.OuterXml;
                                CryptoMain.PrivKey = PrivateKeyXML.OuterXml;
                                pubkey.Text = PublicKeyXML.OuterXml;
                                CryptoMain.PubKey = PublicKeyXML.OuterXml;
                                SessionID.Text = Math.Abs(PubKeyXMLformat.GetHashCode()).ToString();
                                CryptoMain.SessionID = Math.Abs(PubKeyXMLformat.GetHashCode()).ToString();
                            }
                            else
                            {
                                if (selLanguage.Contains("zh"))
                                {
                                    MessageBox.Show("密钥对序列号:" + HashID + " 密钥对序列号不符合", "密钥对数据读取失败 （；´д｀）ゞ", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("SessionID:" + HashID + " The SessionID does not match", "Failed to read key pair data （；´д｀）ゞ", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    catch (Exception error)
                    {
                        if (selLanguage.Contains("zh"))
                        {
                            MessageBox.Show("发现错误了！ 请确认设备ID及2FA密钥是否正确？" + error + " 导入失败", "密钥对数据读取失败 K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Encountered an error！ Please confirm that the SystemID and 2FA key are correct?" + error + " Import failed", "Failed to read key pair data K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }
    }
}
