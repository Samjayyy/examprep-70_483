
namespace Example2._49
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class Base
    {
        public virtual void MethodWithImplementation() { /* Method with implementation */ }

        public abstract void AbstractMethod();
    }

    class Derived : Base
    {
        public override void AbstractMethod() { }
    }
}
