using System;

namespace Example2._47
{
    class Program
    {
        static void Main(string[] args)
        {
            Base example = new Derived();
            example.Execute();

            Console.ReadKey();
        }
    }

    class Base
    {
        public virtual void Execute() {
            Log("executing base class");
        }

        protected void Log(string message) {
            Console.WriteLine(message);
        }
    }

    class Derived : Base
    {
        public override void Execute()
        {
            Log("Before executing");
            base.Execute();
            Log("After executing");
        }
    }
}
