using System;

namespace Example1._60
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = true;
            if (p)
            {
                Write("1");
            }
            else
            {
                Write("1");
            }

            Write((p ? 1 : 0).ToString());

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        private static void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
