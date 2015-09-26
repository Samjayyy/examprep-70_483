using System;
using System.IO;

namespace Example1._94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full .txt file path: ");
            var input = Console.ReadLine();
            Console.WriteLine(OpenAndParse(input));
        }

        public static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                throw new ArgumentNullException("fileName", "Filename is required");
            }

            return File.ReadAllText(fileName);
        }
    }
}
