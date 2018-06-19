﻿using ImageWithSecretLibrary.Interfaces;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ImageWithSecretLibrary
{
    public class AES : IEncrypt
    {
        private byte[] Key;
        private byte[] IV;

        private static readonly byte[] SALT = new byte[] { 0x63, 0x72, 0x79, 0x70, 0x74, 0x6f, 0xfa, 0xfa, 0xfa, 0xfa };
        Rfc2898DeriveBytes pdb;

        public static string EncryptionName = "Advanced Encryption Standard";

        public AES(string key)
        {
            pdb = new Rfc2898DeriveBytes(key, SALT);
            this.Key = CreateKey(key);
            this.IV = pdb.GetBytes(16);
        }

        public byte GetID()
        {
            return 0b00000001;
        }

        public static byte[] CreateKey(string key)
        {
            byte[] bytesOfOwnKey = System.Text.Encoding.UTF8.GetBytes(key);

            // Hash the password with SHA256
            byte[] AESKey = SHA256Managed.Create().ComputeHash(bytesOfOwnKey);

            return AESKey;
        }

        public byte[] Encrypt(byte[] plainText)
        {
            var data = Base64Encode(plainText);
            if (this.Key == null || this.Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (this.IV == null || this.IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = this.Key;
                aesAlg.IV = this.IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(data);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        public byte[] Decrypt(byte[] cipherText)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (this.Key == null || this.Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (this.IV == null || this.IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string base64PlainText = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = this.Key;
                aesAlg.IV = this.IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        try
                        {
                            using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                            {
                                base64PlainText = srDecrypt.ReadToEnd();
                            }
                        }
                        catch
                        {
                            return System.Text.Encoding.UTF8.GetBytes("Wrong password!");
                        }
                    }
                }
            }
            return Base64Decode(base64PlainText);
        }

        public static string Base64Encode(byte[] data)
        {
            return Convert.ToBase64String(data);
        }

        public static byte[] Base64Decode(string data)
        {
            try
            {
                return Convert.FromBase64String(data);
            }
            catch
            {
                return System.Text.Encoding.UTF8.GetBytes("Wrong password!");
            }
        }
    }
}
