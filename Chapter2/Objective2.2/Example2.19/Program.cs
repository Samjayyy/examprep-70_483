using System;

namespace Example2._19
{
    class Program
    {
        static void Main(string[] args)
        {
            string.Concat("To box or not box", 42, true);
            int i = 42;
            object o = i;
            int x = (int)o;

            Console.WriteLine(x);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
