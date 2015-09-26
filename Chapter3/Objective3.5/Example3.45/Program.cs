using System;
using System.Diagnostics;

namespace Example3._45
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLineIf(i > 0, "i is greated than 0");

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
