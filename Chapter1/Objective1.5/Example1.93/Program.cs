using System;

namespace Example1._93
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var i = ReadAndParse();
                Console.WriteLine("Parsed: {0", i);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("StackTrace: {0}", e.StackTrace);
                Console.WriteLine("HelpLink: {0}", e.HelpLink);
                Console.WriteLine("InnerException: {0}", e.InnerException);
                Console.WriteLine("TargetSite: {0}", e.TargetSite);
                Console.WriteLine("Source: {0}", e.Source);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        private static int ReadAndParse()
        {
            Console.Write("Enter a word: ");
            var s = Console.ReadLine();
            var i = int.Parse(s);
            return i;
        }
    }
}
