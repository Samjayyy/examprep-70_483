using System;

namespace Example1._52
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;

            if (b)
            {
                Console.WriteLine("True");
            }

            // Example 1.53
            Console.WriteLine();
            Console.WriteLine("Example 1.53");

            if (b)
            {
                Console.WriteLine("Both these lines");
                Console.WriteLine("Will be executed");
            }

            // Example 1.54
            if (b)
            {
                int r = 42;
                b = false;
            }
            // r is not accessible
            // b is now false

            // Example 1.55
            Console.WriteLine();
            Console.WriteLine("Example 1.55");

            if (b)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


            // Example 1.56
            Console.WriteLine();
            Console.WriteLine("Example 1.56");

            bool c = true;
            if (b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
