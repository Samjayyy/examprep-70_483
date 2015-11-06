using System.IO;

namespace Example1._78
{
    class Program
    {
        private delegate void ContravarianceDel(StreamWriter tw);

        static void Main(string[] args)
        {
            ContravarianceDel del = DoSomething;
        }

        private static void DoSomething(TextWriter tw) { }
    }
}
