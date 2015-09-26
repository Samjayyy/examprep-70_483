using System;
using System.Globalization;

namespace Example2._97
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = 1234.56;
            Console.WriteLine(cost.ToString("C", new CultureInfo("en-US")));

            DateTime d = new DateTime(2014, 3, 11);
            CultureInfo provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider));
            Console.WriteLine(d.ToString("D", provider));
            Console.WriteLine(d.ToString("M", provider));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
