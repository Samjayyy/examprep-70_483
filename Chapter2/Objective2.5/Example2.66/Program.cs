using System;

namespace Example2._66
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class MyMethodAndParameterAttribute : Attribute
    { }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class MyMultipleUsageAttribute : Attribute 
    { }

    [MyMethodAndParameter]
    class MyClass
    {
        [MyMethodAndParameter]
        void MyMethod()
        { }
    }

    [MyMultipleUsage, MyMultipleUsage]
    class MyClassWithMultipleAttribute
    { }

    class CompleteCustomAttribute : Attribute
    {
        public CompleteCustomAttribute(string description)
        {
            this.Description = description;
        }

        public string Description { get; set; }
    }

    [CompleteCustom("Class description")]
    class MyClassWithDescription
    { }
}
