using System;
using System.Diagnostics;

namespace Example2._58
{
    class Program
    {
        static void Main(string[] args)
        {
            var isDefined = Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute));
            Console.WriteLine(string.Format("Person has a Serializable attribute: {0}", isDefined));

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class MyClass
    {
        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        public static void MyMeyhod() { }
    }
}
