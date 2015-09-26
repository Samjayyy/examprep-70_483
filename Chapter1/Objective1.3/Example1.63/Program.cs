using System;

namespace Example1._26
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Case 1");
                        goto case 2;
                    }
                case 2:
                    {
                        Console.WriteLine("Case 2");
                        break;
                    }
            }

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
