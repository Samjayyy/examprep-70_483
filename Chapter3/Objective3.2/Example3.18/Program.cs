using System;
using System.Security.Cryptography;

namespace Example3._18
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            string publicKeyXML = rsa.ToXmlString(false);
            string privateKeyXML = rsa.ToXmlString(true);

            Console.WriteLine("publicKeyXML:");
            Console.WriteLine(publicKeyXML);
            Console.WriteLine();
            Console.WriteLine("privateKeyXML:");
            Console.WriteLine(privateKeyXML);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
