using System;
using System.Reflection;

namespace Example2._73
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int)});
            int result = (int)compareToMethod.Invoke(i, new object[] { 41 });

            Console.WriteLine("42 CompareTo 41 (expected value 1):");
            Console.WriteLine(result);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
