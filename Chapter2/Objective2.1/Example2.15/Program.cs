
using System;

namespace Example2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int: "+MyGenericMethod<int>());
            Console.WriteLine("string: " + MyGenericMethod<string>());
            Console.WriteLine("datetime: " + MyGenericMethod<DateTime>());
            Console.WriteLine("object: " + MyGenericMethod<Object>());
            Console.ReadKey();
        }

        public static T MyGenericMethod<T>()
        {
            return default(T);
        }
    }
}
