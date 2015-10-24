using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Example3._23
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            UnicodeEncoding byteConverter = new UnicodeEncoding();
            SHA256 sha265 = SHA256.Create();

            string data = "A paragraph of text";
            byte[] hashA = sha265.ComputeHash(byteConverter.GetBytes(data));
            Console.WriteLine($"Original data: '{data}'");
            Console.WriteLine($"Original hash: {hashA.ToSentence()}");

            ComputeAndCompare(hashA, sha265, byteConverter, data); // Should always returns same hash
            ComputeAndCompare(hashA, sha265, byteConverter, "A paragraph of changed text");

            
            // other text it is very very very unlikely to have the same hash
            ComputeAndCompare(hashA, sha265, byteConverter, RandomString(random.Next(20)));
            for (var i = 0; i < 100000; i++)
            {
                ComputeAndCompare(hashA, sha265, byteConverter, RandomString(random.Next(20)), crashIfEqual:true);
            }

            Console.WriteLine("------------");
            Console.WriteLine("Done..");
            Console.ReadKey();
        }

        static void ComputeAndCompare(byte[] original, SHA256 sha265, UnicodeEncoding byteConverter, string data, bool crashIfEqual = false)
        {
            byte[] hashed = sha265.ComputeHash(byteConverter.GetBytes(data));
            if(original.SequenceEqual(hashed) || !crashIfEqual)
            {
                if (crashIfEqual)
                {
                    throw new InvalidOperationException("YOU SHOULD PLAY ON THE LOTTERY!");
                }
                else
                {
                    Console.WriteLine("------------");
                    Console.WriteLine($"Encrypted: {hashed.ToSentence()}");
                    Console.WriteLine($"'{data}' has same hash?: {original.SequenceEqual(hashed)}");
                }
            }
        }

        // random helper
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ .";            
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
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
