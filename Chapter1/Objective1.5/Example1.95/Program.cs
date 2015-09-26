using System;
using System.IO;

namespace Example1._95
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
            try
            {
                if (string.IsNullOrWhiteSpace(fileName))
                {
                    throw new ArgumentNullException("fileName", "Filename is required");
                }
            }
            catch (ArgumentNullException ex)
            {
                Log(ex);

                throw; // rethrow the original exception
            }


            return File.ReadAllText(fileName);
        }

        private static void Log(Exception ex)
        {
            // Logging mechanism execute here
        }
    }
}
