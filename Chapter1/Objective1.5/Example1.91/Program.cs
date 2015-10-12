using System;

namespace Example1._91
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
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value.");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again.", s);
            }
            finally
            {
                Console.WriteLine("Program completed.");

                Console.Write("Press a key to exit");
                Console.ReadKey();
            }
        }
    }
}
