using System;
using System.Text.RegularExpressions;

namespace Example3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex(@"[ ]{2,}", options);

            string input = "1 2 3 4  5   6         7";
            Console.WriteLine("Start input is {0}", input);
            string result = regex.Replace(input, " ");

            Console.WriteLine("Parsed input is {0}", result);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
