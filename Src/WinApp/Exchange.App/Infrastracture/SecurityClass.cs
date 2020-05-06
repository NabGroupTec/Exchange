using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Exchange.App.Infrastracture
{
    public static class SecurityClass
    {
        public static byte[] GetHashKey()
        {
            var hashKey = "N@bGroup2!0@1#9";
            var encoder = new UTF8Encoding();
            var salt = "I am a nice little salt";
            var saltBytes = encoder.GetBytes(salt);
            var rfc = new Rfc2898DeriveBytes(hashKey, saltBytes);
            return rfc.GetBytes(16);
        }

        public static string Encrypt(string dataToEncrypt)
        {
            var encryption = new AesManaged();
            encryption.Key = GetHashKey();
            encryption.IV = GetHashKey();
            using (var encryptionStream = new MemoryStream())
            {
                using (var encrypt = new CryptoStream(encryptionStream, encryption.CreateEncryptor(),
                    CryptoStreamMode.Write))
                {
                    var utfD1 = Encoding.UTF8.GetBytes(dataToEncrypt);
                    encrypt.Write(utfD1, 0, utfD1.Length);
                    encrypt.FlushFinalBlock();
                    encrypt.Close();
                    return Convert.ToBase64String(encryptionStream.ToArray());
                }
            }
        }

        public static string Decrypt(string encryptedString)
        {
            var decryption = new AesManaged();
            byte[] encryptedData;
            try
            {
                encryptedData = Convert.FromBase64String(encryptedString);
            }
            catch
            {
                return encryptedString;
            }

            decryption.Key = GetHashKey();
            decryption.IV = GetHashKey();
            using (var decryptionStream = new MemoryStream())
            {
                using (var decrypt = new CryptoStream(decryptionStream, decryption.CreateDecryptor(),
                    CryptoStreamMode.Write))
                {
                    decrypt.Write(encryptedData, 0, encryptedData.Length);
                    decrypt.Flush();
                    decrypt.Close();
                    var decryptedData = decryptionStream.ToArray();
                    return Encoding.UTF8.GetString(decryptedData, 0, decryptedData.Length);
                }
            }
        }
    }
}