using System;

namespace Example1._64
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                Console.Write(values[index]);
            }

            Console.WriteLine();

            for (int x = 0, y = values.Length - 1;
            ((x < values.Length) && (y >= 0));
            x++, y--)
            {
                Console.Write(values[x]);
                Console.Write(values[y]);
            }

            Console.WriteLine();

            for (int index = 0; index < values.Length; index += 2)
            {
                Console.Write(values[index]);
            }

            Console.WriteLine();

            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) break;
                Console.Write(values[index]);
            }

            Console.WriteLine();

            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4) continue;
                Console.Write(values[index]);
            }

            Console.WriteLine();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
