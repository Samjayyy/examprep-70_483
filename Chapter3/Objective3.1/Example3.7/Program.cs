using System;

namespace Example3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Convert null to Int32: {Convert.ToInt32(null)}");
            double d = 23.15;
            Console.WriteLine($"Convert '{d}' to Int32: {Convert.ToInt32(d)}");
            d = 2147483647.5D;
            Console.WriteLine($"Convert '{d}' to Int32: {Convert.ToInt32(d)}");
            d = -2147483648.5D;
            Console.WriteLine($"Convert '{d}' to Int32: {Convert.ToInt32(d)}");

            Console.ReadKey();
        }
    }
}
