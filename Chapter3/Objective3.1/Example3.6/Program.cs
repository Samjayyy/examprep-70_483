using System;
using System.Globalization;

namespace Example3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var english = new CultureInfo("En");
            var dutch = new CultureInfo("Nl");

            string value = "€19,95";
            decimal result;
            if(decimal.TryParse(value, NumberStyles.Currency, dutch, out result)){
                Console.WriteLine($"parse in NL, print in NL {result.ToString(dutch)}");
                Console.WriteLine($"parse in NL, print in EN {result.ToString(english)}");
            }
            Console.WriteLine("-----------------");
            if (decimal.TryParse(value, NumberStyles.Currency, english, out result))
            {
                Console.WriteLine($"parse in EN, print in EN {result.ToString(english)}");
                Console.WriteLine($"parse in EN, print in NL {result.ToString(dutch)}");
            }
            else
            {
                Console.WriteLine("You shall not parse! euros in english"); // gandalf
            }
            Console.WriteLine("-----------------");

            Console.ReadKey();
        }
    }
}
