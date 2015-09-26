using System;

namespace Example1._58
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;

            Console.WriteLine(y);

            // Example 1.59
            Console.WriteLine();
            Console.WriteLine("Example 1.59");

            int? z = null;
            int y2 = x ??
                     z ??
                     -1;

            Console.WriteLine(y2);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
