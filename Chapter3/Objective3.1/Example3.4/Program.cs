using System;

namespace Example3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "true";
            bool b = bool.Parse(value);
            Console.WriteLine(b);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
