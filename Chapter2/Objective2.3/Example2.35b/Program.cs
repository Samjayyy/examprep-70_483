using System;

namespace Example2._35
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new MyPublicClass();
            c.MyMethod();

            var c2 = new MyInternalClass();
            c2.MyMethod(); // friend assembly, hooray

            Console.ReadKey();
        }
    }
}
