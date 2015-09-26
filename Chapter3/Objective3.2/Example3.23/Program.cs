using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Example3._23
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha265 = SHA256.Create();

            string data = "A paragraph of text";
            byte[] hashA = sha265.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine("hashA: {0}", hashA.ToSentence());

            data = "A paragraph of changed text";
            byte[] hashB = sha265.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine("hashB: {0}", hashB.ToSentence());

            data = "A paragraph of text";
            byte[] hashC = sha265.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine("hashC: {0}", hashC.ToSentence());
            Console.WriteLine();
            Console.WriteLine("hashA.SequenceEqual(hashB): {0}", hashA.SequenceEqual(hashB));
            Console.WriteLine("hashA.SequenceEqual(hashC): {0}", hashA.SequenceEqual(hashC));


            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }

    public static class Extensions
    {
        public static string ToSentence(this byte[] array)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var member in array)
            {
                sb.Append(member);
            }

            return sb.ToString();
        }
    }
}
