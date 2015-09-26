
namespace Example2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.MyInstanceField = "Some New Value";
            MyClass.MyStaticField = 43;
        }
    }

    public class MyClass
    {
        public string MyInstanceField;

        public static int MyStaticField = 42;

        public string Concatenete(string valueToAppend)
        {
            return MyInstanceField + valueToAppend;
        }
    }
}
