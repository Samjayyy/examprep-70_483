using System;
using System.Reflection;

namespace Example3._36
{
    class Program
    {
        static void Main(string[] args)
        {
            var intAssembly = LoadAssembly<int>();
            Console.WriteLine("Loading int assembly:");
            Console.WriteLine(intAssembly);

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public static Assembly LoadAssembly<T>()
        { 
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
            Assemble assembly = typeof(T).GetTypeInfo().Assembly;
#endif

            return assembly;
        }
    }
}
