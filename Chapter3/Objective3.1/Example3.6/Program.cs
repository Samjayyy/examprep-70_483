using System;
using System.Globalization;

namespace Example3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo english = new CultureInfo("En");
            CultureInfo dutch = new CultureInfo("Nl");

            string value = "€19,95";
            decimal d = decimal.Parse(value, NumberStyles.Currency, dutch);
            Console.WriteLine(d.ToString(english));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
