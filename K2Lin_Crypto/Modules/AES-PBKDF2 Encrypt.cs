using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class AES
{
    public static string sha256(string randomString)
    {
        var crypt = new SHA256Managed();
        byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
        return Encoding.UTF8.GetString(crypto);
    }
    public static byte[] sha256byte(string randomString)
    {
        var crypt = new SHA256Managed();
        byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
        return crypto;
    }
    public static byte[] PBKDF2Hash(string input, byte[] salt)
    {
        // Generate the hash
        Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, iterations: 1000);
        return pbkdf2.GetBytes(16); //16 bytes length is 128 bits , SHA256 formatted it
    }
    public static string Encrypt(string plainText, string keyString)
    {
        byte[] cipherData;
        Aes aes = Aes.Create();
        aes.Key = sha256byte(keyString);
        aes.GenerateIV();
        aes.Mode = CipherMode.CBC;
        ICryptoTransform cipher = aes.CreateEncryptor(aes.Key, aes.IV);

        using (MemoryStream ms = new MemoryStream())
        {
            using (CryptoStream cs = new CryptoStream(ms, cipher, CryptoStreamMode.Write))
            {
                using (StreamWriter sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                }
            }

            cipherData = ms.ToArray();
        }

        byte[] combinedData = new byte[aes.IV.Length + cipherData.Length];
        Array.Copy(aes.IV, 0, combinedData, 0, aes.IV.Length);
        Array.Copy(cipherData, 0, combinedData, aes.IV.Length, cipherData.Length);
        return Convert.ToBase64String(combinedData);
    }

    public static string Decrypt(string combinedString, string keyString)
    {
        string plainText;
        byte[] combinedData = Convert.FromBase64String(combinedString);
        Aes aes = Aes.Create();
        aes.Key = sha256byte(keyString);
        byte[] iv = new byte[aes.BlockSize / 8];
        byte[] cipherText = new byte[combinedData.Length - iv.Length];
        Array.Copy(combinedData, iv, iv.Length);
        Array.Copy(combinedData, iv.Length, cipherText, 0, cipherText.Length);
        aes.IV = iv;
        aes.Mode = CipherMode.CBC;
        ICryptoTransform decipher = aes.CreateDecryptor(aes.Key, aes.IV);

        using (MemoryStream ms = new MemoryStream(cipherText))
        {
            using (CryptoStream cs = new CryptoStream(ms, decipher, CryptoStreamMode.Read))
            {
                using (StreamReader sr = new StreamReader(cs))
                {
                    plainText = sr.ReadToEnd();
                }
            }

            return plainText;
        }
    }
}