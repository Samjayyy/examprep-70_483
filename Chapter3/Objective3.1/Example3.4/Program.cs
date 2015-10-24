using System;

namespace Example3._4
{
    class Program
    {
        static void Main(string[] args)
        {            
            // internals using
            Console.WriteLine($"internals using: {bool.TrueString} vs {bool.FalseString}");

            // Let's parse
            ParsingTest("trUE");
            ParsingTest("fAlse");
            ParsingTest("1");
            ParsingTest("true-");
            ParsingTest("       true      ");


            Console.ReadKey();
        }
        static void ParsingTest(string value)
        {
            Console.WriteLine("-------------------");
            try
            {
                Console.WriteLine($"Parsing '{value}': {bool.Parse(value)}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FOUT bij Parsing '{value}': {ex.Message}");
            }
        }
    }
}
