using System;
using System.Security.Cryptography;
using System.Text;

namespace Example3._20
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My secret data!");
            Console.WriteLine("Encrypting: {0}", ByteConverter.GetString(dataToEncrypt));
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            Console.WriteLine("Encrypted data: {0}", ByteConverter.GetString(encryptedData));

            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            string decryptedString = ByteConverter.GetString(decryptedData);
            Console.WriteLine("Decrypted data: {0}", decryptedString);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
