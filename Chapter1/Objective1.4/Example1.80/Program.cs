using System;

namespace Example1._80
{
    class Program
    {
        public delegate int Calculate(int x, int y);

        static void Main(string[] args)
        {
            Calculate calc =
                (x, y) =>
                {
                    Console.WriteLine("Adding numbers {0} + {1}", x, y);
                    return x + y;
                };
            int result = calc(3, 4);

            Console.WriteLine(result);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
