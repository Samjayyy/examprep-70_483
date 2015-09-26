using System;

namespace Example1._79
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
