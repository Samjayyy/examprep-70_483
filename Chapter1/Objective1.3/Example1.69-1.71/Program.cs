using System;

namespace Example1._69
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            {
                int index = 0;
                while (index < values.Length)
                {
                    Console.Write(values[index]);
                    index++;
                }
            }

            Console.WriteLine();

            do
            {
                Console.WriteLine("Executed once!");
            }
            while (false);

            Console.WriteLine();

            foreach (int i in values)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
