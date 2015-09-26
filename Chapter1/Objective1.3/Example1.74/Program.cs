using System;

namespace Example1._74
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            if (x == 3)
            {
                goto customLabel;
            }

            x++; // Not reached
            customLabel:
            Console.WriteLine(x);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
