
using System;

namespace Example4._82
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = 
            {
                new int[] {1, 3, 5, 7, 9},
                new int[] {0, 2, 4, 6},
                new int[] {42, 21}
            };


            Console.WriteLine(jaggedArray[0][0]);
            Console.WriteLine(jaggedArray[0][1]);
            Console.WriteLine(jaggedArray[1][0]);
            Console.WriteLine(jaggedArray[1][1]);
            Console.WriteLine(jaggedArray[2][0]);
            Console.WriteLine(jaggedArray[2][1]);

            Console.WriteLine();
            Console.WriteLine("---------------");
            Console.WriteLine();

            int[][] jaggedArray2 = new int[3][];
            int counter = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray2[i] = new int[i+1];
                for(int j = 0; j<i+1;j++)
                {
                    jaggedArray2[i][j] = counter++;
                }
            }

            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.Write($"[{jaggedArray2[i][j]}] ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
