#define MySymbol
using System;

namespace Example3._34
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugDirective();
            UseCustomSymbol();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("Not debug");
#endif
        }

        public static void UseCustomSymbol()
        { 
#if MySymbol
            Console.WriteLine("Custom symbol is defined.");
#endif
        }
    }
}
