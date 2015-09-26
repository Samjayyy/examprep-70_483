
namespace Example2._18
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Base
    {
        public virtual int MyMethod()
        {
            return 42;
        }
    }

    class Derived : Base
    {
        public sealed override int MyMethod()
        {
            return base.MyMethod() * 2;
        }
    }

    class Derived2 : Derived
    {
        // This line would give an compile error
        //public override int MyMethod()
        //{
        //    return 1;
        //}
    }
}
