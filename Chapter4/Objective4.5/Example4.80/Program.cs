using System;

namespace Example4._80
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = new int[10];

            for (int x = 0; x < arrayOfInt.Length; x++)
            {
                arrayOfInt[x] = x;
            }

            //int[] arrayOfInt = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in arrayOfInt)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
