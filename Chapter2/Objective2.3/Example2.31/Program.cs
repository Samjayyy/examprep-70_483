
using System;

namespace Example2._31
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Bark();

            Console.ReadKey();
        }
    }

    public class Dog
    { 
        public void Bark() {
            Console.WriteLine("Bark, Bark");
        }

    }
}
