using System;

namespace Example4._81
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            Console.WriteLine(array2D[0, 0]);
            Console.WriteLine(array2D[0, 1]);
            Console.WriteLine(array2D[1, 0]);
            Console.WriteLine(array2D[1, 1]);
            Console.WriteLine(array2D[2, 0]);
            Console.WriteLine(array2D[2, 1]);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
