using K2Lin_Crypto.Modules;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace K2Lin_Crypto.Forms
{
    public partial class PNGSteganography : Form
    {
        public PNGSteganography()
        {
            InitializeComponent();
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                ReadButton.Font = CryptoMain.zhHans_waresu;
                SaveButton.Font = CryptoMain.zhHans_waresu;
                EncryptButton.Font = CryptoMain.zhHans_waresu;
                DecryptButton.Font = CryptoMain.zhHans_waresu;
                TextBox.Font = CryptoMain.zhHans_waresu;
                LocationBox.Font = CryptoMain.Eng_Comfortaa;
            }
            else
            {
                ReadButton.Font = CryptoMain.Eng_Comfortaa;
                SaveButton.Font = CryptoMain.Eng_Comfortaa;
                EncryptButton.Font = CryptoMain.Eng_Comfortaa;
                DecryptButton.Font = CryptoMain.Eng_Comfortaa;
                TextBox.Font = CryptoMain.zhHans_waresu;
                LocationBox.Font = CryptoMain.Eng_Comfortaa;
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                ReadPNG.Title = "请选择读取的PNG文件.";
                ReadPNG.Filter = "PNG 图像 (*.png)|*.png";
            }
            else
            {
                ReadPNG.Title = "Please select an PNG file to read.";
                ReadPNG.Filter = "PNG Images (*.png)|*.png";
            }
            using (OpenFileDialog ReadPNG = new OpenFileDialog())
            {
                if (ReadPNG.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LocationBox.Text = ReadPNG.FileName.ToString();

                        PNGPreview.ImageLocation = LocationBox.Text;
                    }
                    catch (Exception error)
                    {
                        if (selLanguage.Contains("zh"))
                        {
                            MessageBox.Show("发现错误了！ " + error + " 读取PNG文件失败", "PNG数据读取失败 K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("Encountered an error！" + error + " Failed to read PNG file", "Failed to read PNG data K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap loadedBitmap = new Bitmap(PNGPreview.Image);

                string plaincipher = SteganographyModule.ExtractText(loadedBitmap);

                XmlDocument SteganographyXML = new XmlDocument();
                SteganographyXML.LoadXml(plaincipher);
                string cipherpath = "K2LinCrypto/SteganoText";
                string base64cipher = SteganographyXML.SelectSingleNode(cipherpath).InnerText;

                byte[] bytes = Convert.FromBase64String(base64cipher);
                string cipher = Encoding.UTF8.GetString(bytes);

                TextBox.Text = cipher;
            }
            catch (Exception)
            {
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    MessageBox.Show("发现错误了！" + " 读取失败 - 没有密文？", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error found!" + " Failed to read - no cipher?", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap loadedBitmap = new Bitmap(PNGPreview.Image);

                byte[] bytes = Encoding.UTF8.GetBytes(TextBox.Text);
                string base64cipher = Convert.ToBase64String(bytes);

                XmlDocument SteganographyXML = new XmlDocument();
                SteganographyXML.LoadXml("<K2LinCrypto></K2LinCrypto>");
                XmlElement cipherText = SteganographyXML.CreateElement("SteganoText");
                cipherText.InnerText = base64cipher;
                SteganographyXML.DocumentElement.AppendChild(cipherText);
                string plaincipher = SteganographyXML.OuterXml;

                Bitmap encryptedBitmap = SteganographyModule.EmbedText(plaincipher, loadedBitmap);

                PNGPreview.Image = encryptedBitmap;
            }
            catch (Exception)
            {
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    MessageBox.Show("发现错误了！" + " 执行失败-密文过长？", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error found!" + " Failed to execute - too long cipher?", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SavePNG = new SaveFileDialog();

                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    SavePNG.Title = "请选择PNG文件以保存图像.";
                    SavePNG.Filter = "PNG 图像 (*.png)|*.png";
                }
                else
                {
                    SavePNG.Title = "Please select an PNG file to save the image.";
                    SavePNG.Filter = "PNG Images (*.png)|*.png";
                }
                ImageFormat format = ImageFormat.Png;

                if (SavePNG.ShowDialog() == DialogResult.OK)
                {
                    string ext = System.IO.Path.GetExtension(SavePNG.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    PNGPreview.Image.Save(SavePNG.FileName, format);
                }
            }
            catch (Exception)
            {
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    MessageBox.Show("发现错误了！" + " 保存失败-文件错误？", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error found!" + " Failed to read - corrupt file?", "K2Lin Crypto （；´д｀）ゞ", MessageBoxButtons.OK);
                }
            }
        }

        private void PNGPreview_DoubleClick(object sender, EventArgs e)
        {
            if (PNGPreview.Image == null) return;

            Clipboard.SetDataObject(PNGPreview.Image);
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                MessageBox.Show("已复制到剪贴板！", "K2Lin Crypto (｡･∀･)ﾉﾞ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Copied to the clipboard!", "K2Lin Crypto (｡･∀･)ﾉﾞ", MessageBoxButtons.OK);
            }
        }

        private bool PNGPrevie_ImportClipboard()
        {
            string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
            if (selLanguage.Contains("zh"))
            {
                DialogResult dialogResult = MessageBox.Show("您想将剪贴板中的内容打开嘛？", "K2Lin Crypto (￣︶￣*))", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    // Get the clipboard's image.
                    PNGPreview.Image = Clipboard.GetImage();

                    MessageBox.Show("剪贴板图片已读取！", "K2Lin Crypto (｡･∀･)ﾉﾞ", MessageBoxButtons.OK);
                    return true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    return false;
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to open the contents of the clipboard?", "K2Lin Crypto (￣︶￣*))", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    // Get the clipboard's image.
                    PNGPreview.Image = Clipboard.GetImage();

                    MessageBox.Show("Copied from clipboard!", "K2Lin Crypto (｡･∀･)ﾉﾞ", MessageBoxButtons.OK);
                    return true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    return false;
                }
            }
            return false;
        }

        private void PNGPreview_MouseEnter(object sender, EventArgs e)
        {
            PNGPreview.Focus();
        }

        private void PNGPreview_MouseLeave(object sender, EventArgs e)
        {
            Focus();
        }

        private void PNGPreview_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                // Do nothing if the clipboard doesn't hold an image.
                if (Clipboard.ContainsImage())
                {
                    if (PNGPrevie_ImportClipboard()) return;
                }
            }
            else if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                if (PNGPreview.Image == null) return;

                Clipboard.SetDataObject(PNGPreview.Image);
                string selLanguage = System.Globalization.CultureInfo.CurrentUICulture.Name;
                if (selLanguage.Contains("zh"))
                {
                    MessageBox.Show("图像已复制到剪贴板！", "K2Lin Crypto (｡･∀･)ﾉﾞ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Image copied to the clipboard!", "K2Lin Crypto (｡･∀･)ﾉﾞ", MessageBoxButtons.OK);
                }
            }
        }
    }
}


