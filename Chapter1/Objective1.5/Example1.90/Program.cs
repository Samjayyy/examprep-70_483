using System;

namespace Example1._90
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "NaN"; // Throws FormatException

            string s = null; // Throws ArgumentNullException

            try
            {
                int i = int.Parse(s);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value.");
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
