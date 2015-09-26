using System;

namespace Example2._95
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "My Custom Value";
            foreach (char c in value)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
            foreach (string word in value.Split(' '))
            {
                Console.WriteLine(word);
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
