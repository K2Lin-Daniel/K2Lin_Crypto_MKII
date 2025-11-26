using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using K2Lin_Crypto.Modules;

namespace K2Lin_Crypto.Forms
{
    public partial class StegoDecrypt : Form
    {
        private Bitmap stegoImage;
        string privkey = CryptoMain.PrivKey;

        public StegoDecrypt()
        {
            InitializeComponent();
            selectImageButton.Click += new EventHandler(selectImageButton_Click);
            decryptButton.Click += new EventHandler(decryptButton_Click);
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                stegoImage = new Bitmap(openFileDialog.FileName);
                pictureBox.Image = stegoImage;
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (stegoImage == null)
            {
                MessageBox.Show("Please select a stego image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Extract the hidden data from the received PNG image.
                string extractedBase64 = SteganographyModule.ExtractText(stegoImage);
                byte[] extractedData = Convert.FromBase64String(extractedBase64);

                // 2. Parse the extracted data to separate the RSA-encrypted AES key and IV from the AES-encrypted message.
                byte[] encryptedAesKeyAndIv = new byte[256];
                byte[] encryptedMessage = new byte[extractedData.Length - 256];
                Buffer.BlockCopy(extractedData, 0, encryptedAesKeyAndIv, 0, 256);
                Buffer.BlockCopy(extractedData, 256, encryptedMessage, 0, encryptedMessage.Length);

                // 3. Decrypt the AES key and IV using the recipient's private RSA key.
                byte[] aesKeyAndIv;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    XmlDocument privateKeyXml = new XmlDocument();
                    privateKeyXml.LoadXml(privkey);
                    string privKeyPath = "K2LinCrypto/PrivateKey";
                    string privKey = privateKeyXml.SelectSingleNode(privKeyPath).InnerText;
                    rsa.FromXmlString(privKey);
                    aesKeyAndIv = rsa.Decrypt(encryptedAesKeyAndIv, true);
                }

                byte[] aesKey = new byte[32];
                byte[] aesIv = new byte[16];
                Buffer.BlockCopy(aesKeyAndIv, 0, aesKey, 0, 32);
                Buffer.BlockCopy(aesKeyAndIv, 32, aesIv, 0, 16);

                // 4. Decrypt the message using the recovered AES key and IV.
                string decryptedMessage;
                using (Aes aes = Aes.Create())
                {
                    aes.Key = aesKey;
                    aes.IV = aesIv;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    using (MemoryStream msDecrypt = new MemoryStream(encryptedMessage))
                    {
                        using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                decryptedMessage = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                }

                decryptoResult.Text = decryptedMessage;
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error！" + error + " Decryption failed", "K2Lin Crypto （；´d｀）ゞ", MessageBoxButtons.OK);
            }
        }
    }
}
