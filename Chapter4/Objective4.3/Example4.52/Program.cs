using System;

namespace Example4._52
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("2 * 3 = {0}", x.Multiply(3));

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }

    public static class IntExtensions
    {
        public static int Multiply(this int x, int y)
        {
            return x * y;
        }
    }
}
