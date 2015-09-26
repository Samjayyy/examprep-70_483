using System;

namespace Example1._89
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "NaN";
            try
            {
                int i = int.Parse(s);
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
