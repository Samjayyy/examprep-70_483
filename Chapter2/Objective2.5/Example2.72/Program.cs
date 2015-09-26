using System;
using System.Reflection;

namespace Example2._72
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = 8;
            Console.WriteLine("DumpObject with int:");
            DumpObject(integer);

            MyClass myObject = new MyClass(1, 123);
            Console.WriteLine("DumpObject with MyClass:");
            DumpObject(myObject);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        static void DumpObject(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo field in fields)
            {
                if (field.FieldType == typeof(int))
                {
                    Console.WriteLine(field.GetValue(obj));
                }
            }
        }
    }

    class MyClass
    {
        public MyClass(int id, int number)
        {
            this.Id = id;
            this.Number = number;
        }

        public int Id { get; set; }

        public int Number { get; set; }
    }
}
