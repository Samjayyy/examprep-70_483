using System;

namespace Example3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Convert.ToInt32(null);
            Console.WriteLine(i);

            double d = 23.15;
            int i2 = Convert.ToInt32(d);
            Console.WriteLine(i2);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
