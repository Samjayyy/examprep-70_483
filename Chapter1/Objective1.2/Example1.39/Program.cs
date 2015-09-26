using System;
using System.Threading.Tasks;

namespace Example1._39
{
    class Program
    {
        private static int _flag = 0;

        // Resolves the issue, by disabling the compiler optimizations.
        //private static volatile int _flag = 0;

        private static int _value = 0;

        // Running this programs may lead to different results each time
        static void Main(string[] args)
        {
            Task.Run(() =>
                {
                    Thread1();
                });
            Task.Run(() =>
            {
                Thread2();
            });

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
            {
                Console.WriteLine(_value);
            }
        }
    }
}
