using System;

namespace Example2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new ConstructorChaning().ToString());
            Console.WriteLine(new ConstructorChaning(5).ToString());
            Console.ReadKey();
        }
    }

    class ConstructorChaning
    {
        private int p;

        public ConstructorChaning() : this(3){ }

        public ConstructorChaning(int p)
        {
            this.p = p;
        }
        public override string ToString()
        {
            return $"p: {p}";
        }
    }
}
