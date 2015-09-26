using System;

namespace Example2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNumber = new MyNullable<int>(5);
            Console.WriteLine($"my number: {myNumber.HasValue} => {myNumber.Value}");
            Console.WriteLine($"Operations: {myNumber.Value * 2}");
            Console.ReadKey();
        }
    }

    struct MyNullable<T> where T : struct
    {
        private bool hasValue;
        private T value;

        public MyNullable(T value)
        {
            hasValue = true;
            this.value = value;
        }

        public bool HasValue { get { return hasValue; } }

        public T Value
        {
            get 
            {
                if (!HasValue)
                {
                    throw new ArgumentException();
                }

                return value;
            }
        }
    }
}
