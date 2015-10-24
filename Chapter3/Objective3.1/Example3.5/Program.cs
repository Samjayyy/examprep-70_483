using System;

namespace Example3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            ParsingTest("1");
            ParsingTest("A");
            ParsingTest("1.0");
            ParsingTest("1e6");
            ParsingTest("1a");
            ParsingTest("     23    ");
            ParsingTest("1 2");
            ParsingTest("+1");
            ParsingTest("-1");
            ParsingTest(" -1 ");
            ParsingTest("- 1");
            Console.ReadKey();
        }

        static void ParsingTest(string value)
        {
            Console.WriteLine("-----");
            int result;
            Console.WriteLine($"Parsing '{value}'");
            var success = int.TryParse(value, out result);

            if (success)
            {
                Console.WriteLine($"Parsing succeeded {result}");
            }
            else
            {
                Console.WriteLine($"Parsing failed {result}");
            }
        }
    }
}
