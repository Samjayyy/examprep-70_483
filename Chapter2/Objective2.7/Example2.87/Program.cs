using System;
using System.Text;

namespace Example2._87
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("A initial value");
            Console.WriteLine(sb);
            sb[0] = 'B';
            Console.WriteLine(sb);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
