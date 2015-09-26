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

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void EncryptDecryptSomeText()
        {
            string original = "My secret data!";
            Console.WriteLine(string.Format("Encripting: {0}", original));
            using (SymmetricAlgorithm symmetricAnglorith = new AesManaged())
            {
                byte[] encrypted = Encrypt(symmetricAnglorith, original);
                Console.WriteLine(string.Format("Encrypted result: {0}", encrypted.ToSentence()));
                string dencrypted = Decrypt(symmetricAnglorith, encrypted);
                Console.WriteLine(string.Format("Dencrypted result: {0}", dencrypted));
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
