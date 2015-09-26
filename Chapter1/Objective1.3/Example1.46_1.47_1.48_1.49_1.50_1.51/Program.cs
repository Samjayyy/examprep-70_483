using System;

namespace Example1._46
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 1;
            int z = 42;

            Console.WriteLine(x == y);
            Console.WriteLine(x == z);

            // Example 1.47
            Console.WriteLine();
            Console.WriteLine("Example 1.47");

            bool x1 = true;
            bool y1 = false;

            bool result = x1 || y1;

            Console.WriteLine(result);

            // Example 1.48
            Console.WriteLine();
            Console.WriteLine("Example 1.48");

            OrShortCircuit();

            // Example 1.49
            Console.WriteLine();
            Console.WriteLine("Example 1.49");
            int value = 42;
            bool result2 = (0 < value) && (value < 100);
            Console.WriteLine(result2);

            // Example 1.50
            Console.WriteLine();
            Console.WriteLine("Example 1.50");

            Process(null);

            // Example 1.51
            Console.WriteLine();
            Console.WriteLine("Example 1.51");
            bool a = true;
            bool b = false;

            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void OrShortCircuit()
        {
            bool result = GetX() || GetY();
        }

        private static bool GetX()
        {
            Console.WriteLine("GetX() method does gets called");

            return true;
        }

        private static bool GetY()
        {
            Console.WriteLine("GetY() method doesn't get called");

            return true;
        }

        public static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v")); // Does not throw excpetion because of short-circuiting
            // Do something with the result
        }
    }
}
