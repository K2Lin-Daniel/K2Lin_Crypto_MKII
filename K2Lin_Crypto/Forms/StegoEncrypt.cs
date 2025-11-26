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
    public partial class StegoEncrypt : Form
    {
        private Bitmap coverImage;

        public StegoEncrypt()
        {
            InitializeComponent();
            selectImageButton.Click += new EventHandler(selectImageButton_Click);
            saveImageButton.Click += new EventHandler(saveImageButton_Click);
            encryptButton.Click += new EventHandler(encryptButton_Click);
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files (*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                coverImage = new Bitmap(openFileDialog.FileName);
                pictureBox.Image = coverImage;
            }
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Files (*.png)|*.png";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (coverImage == null)
            {
                MessageBox.Show("Please select a cover image first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // 1. Generate a random 256-bit AES key and IV.
                byte[] aesKey = new byte[32];
                byte[] aesIv = new byte[16];
                using (var rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(aesKey);
                    rng.GetBytes(aesIv);
                }

                // 2. Encrypt the user's message using AES-256-CBC.
                byte[] encryptedMessage;
                using (Aes aes = Aes.Create())
                {
                    aes.Key = aesKey;
                    aes.IV = aesIv;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;
                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                swEncrypt.Write(encryptoText.Text);
                            }
                            encryptedMessage = msEncrypt.ToArray();
                        }
                    }
                }

                // 3. Encrypt the AES key and IV using the recipient's public RSA key.
                byte[] encryptedAesKeyAndIv;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    XmlDocument publicKeyXml = new XmlDocument();
                    publicKeyXml.LoadXml(receiverPublic.Text);
                    string pubKeyPath = "K2LinCrypto/PublicKey";
                    string receiverPubKey = publicKeyXml.SelectSingleNode(pubKeyPath).InnerText;
                    rsa.FromXmlString(receiverPubKey);
                    byte[] keyAndIv = new byte[aesKey.Length + aesIv.Length];
                    Buffer.BlockCopy(aesKey, 0, keyAndIv, 0, aesKey.Length);
                    Buffer.BlockCopy(aesIv, 0, keyAndIv, aesKey.Length, aesIv.Length);
                    encryptedAesKeyAndIv = rsa.Encrypt(keyAndIv, true);
                }

                // 4. Concatenate the RSA-encrypted AES key and IV with the AES-encrypted message.
                byte[] dataToEmbed = new byte[encryptedAesKeyAndIv.Length + encryptedMessage.Length];
                Buffer.BlockCopy(encryptedAesKeyAndIv, 0, dataToEmbed, 0, encryptedAesKeyAndIv.Length);
                Buffer.BlockCopy(encryptedMessage, 0, dataToEmbed, encryptedAesKeyAndIv.Length, encryptedMessage.Length);

                // 5. Embed the concatenated data into the cover image.
                Bitmap stegoImage = SteganographyModule.EmbedText(Convert.ToBase64String(dataToEmbed), coverImage);
                pictureBox.Image = stegoImage;
                MessageBox.Show("Data embedded in image successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show("Encountered an error！" + error + " Encryption failed", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
            }
        }
    }
}
