using System;
using System.Collections.Generic;

namespace Example4._84
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = new List<string> { "A", "B", "C", "D", "E" };
            for (int x = 0; x < listOfStrings.Count; x++)
            {
                Console.Write(listOfStrings[x]);
            }

            listOfStrings.Remove("A");

            Console.WriteLine();
            Console.WriteLine("At 0: {0}", listOfStrings[0]);

            listOfStrings.Add("F");
            Console.WriteLine("Count: {0}", listOfStrings.Count);

            bool hasC = listOfStrings.Contains("C");

            Console.WriteLine("Has 'C': {0}", hasC);

            Console.Write("Press a key to exit ... ");
            Console.ReadKey();
        }
    }
}
