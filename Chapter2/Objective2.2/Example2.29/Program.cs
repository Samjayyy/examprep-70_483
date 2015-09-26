using System;
using System.Dynamic;

namespace Example2._29
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new SampleObject();
            Console.WriteLine(obj.SomeProperty);

            dynamic obj2 = new ExpandoObject();
            obj2.Test = "dit is een test property";
            Console.WriteLine(obj2.Test);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    public class SampleObject : DynamicObject
    {
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = binder.Name;
            return true;
        }
    }
}
