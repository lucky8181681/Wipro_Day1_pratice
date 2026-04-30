using System;
using System.Security.Cryptography;
using System.Text;

namespace UserManagementSystem.Utils
{
    public class EncryptionHelper
    {
        private static readonly string key = "1234567890123456"; // 16 chars

        public static string Encrypt(string text)
        {
            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.GenerateIV();

            var encryptor = aes.CreateEncryptor();

            byte[] encrypted = encryptor.TransformFinalBlock(
                Encoding.UTF8.GetBytes(text), 0, text.Length);

            return Convert.ToBase64String(aes.IV) + ":" + Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string cipher)
        {
            var parts = cipher.Split(':');

            using var aes = Aes.Create();
            aes.Key = Encoding.UTF8.GetBytes(key);
            aes.IV = Convert.FromBase64String(parts[0]);

            var decryptor = aes.CreateDecryptor();

            byte[] decrypted = decryptor.TransformFinalBlock(
                Convert.FromBase64String(parts[1]), 0,
                Convert.FromBase64String(parts[1]).Length);

            return Encoding.UTF8.GetString(decrypted);
        }
    }
}