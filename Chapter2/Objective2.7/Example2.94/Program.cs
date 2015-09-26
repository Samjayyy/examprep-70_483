using System;
using System.Text.RegularExpressions;

namespace Example2._94
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.?)";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
            {
                Console.WriteLine(Regex.Replace(name, pattern, string.Empty));
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
