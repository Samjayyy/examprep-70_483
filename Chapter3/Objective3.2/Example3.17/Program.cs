using System;
using System.IO;
using System.Security.Cryptography;

namespace Example3._17
{
    class Program
    {
        static void Main(string[] args)
        {
            EncryptDecryptSomeText();
            Console.ReadKey();
        }

        public static void EncryptDecryptSomeText()
        {
            string original = "My secret data!";
            Console.WriteLine($"Encrypting: {original}");
            using (SymmetricAlgorithm symmetricAnglorithm = new AesManaged())
            {
                byte[] encrypted = Encrypt(symmetricAnglorithm, original);
                Console.WriteLine($"Encrypted result: {encrypted.ToSentence()}");
                string decrypted = Decrypt(symmetricAnglorithm, encrypted);
                Console.WriteLine($"Decrypted result: {decrypted}");
            }
        }

        private static byte[] Encrypt(SymmetricAlgorithm aesAlg, string plainText)
        {
            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    return msEncrypt.ToArray();
                }
            }
        }

        private static string Decrypt(SymmetricAlgorithm aesAlg, byte[] cipherText)
        {
            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
    }

    public static class Excensions
    {
        public static string ToSentence(this byte[] array)
        {
            string result = string.Empty;
            foreach (var i in array)
            {
                result += i.ToString();
            }

            return result;
        }
    }
}
