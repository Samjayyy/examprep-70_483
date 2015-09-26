using System;

namespace Example3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "1";
            Console.WriteLine("Parsing {0}", value);
            int result;
            bool success = int.TryParse(value, out result);

            if (success)
            {
                Console.WriteLine("Parsing succeeded {0}", result);
            }
            else
            {
                Console.WriteLine("Parsing failed {0}", result);
            }


            value = "A";
            Console.WriteLine("Parsing {0}", value);
            success = int.TryParse(value, out result);

            if (success)
            {
                Console.WriteLine("Parsing succeeded {0}", result);
            }
            else
            {
                Console.WriteLine("Parsing failed {0}", result);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
