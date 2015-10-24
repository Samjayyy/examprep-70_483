using System;
using System.Text.RegularExpressions;

namespace Example3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[ ]{2,}", RegexOptions.None);

            var input = "1 2 3 4  5   6         7";
            Console.WriteLine($"Start input is {input}");
            var result = regex.Replace(input, " ");
            Console.WriteLine($"Parsed input is {result}");
            Console.ReadKey();
        }        
    }
}
