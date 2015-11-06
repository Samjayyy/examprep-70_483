using System;

namespace Example1._89
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "NaN";
            try
            {
                var i = int.Parse(s);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again.", s);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
