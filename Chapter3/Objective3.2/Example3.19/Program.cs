using System;
using System.Security.Cryptography;
using System.Text;

namespace Example3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My secret data!");
            Console.WriteLine("Encrypting: {0}", ByteConverter.GetString(dataToEncrypt));

            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(publicKeyXML);
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            Console.WriteLine("Encrypted data: {0}", ByteConverter.GetString(encryptedData));

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                RSA.FromXmlString(privateKeyXML);
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine("Decrypted data: {0}", decryptedString);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
