
using System;

namespace Example2._44
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();

            MoveAnimal(animal);

            //animal.Bark(); This will thrown an compile error
            (animal as Dog).Bark(); // Is allowed

            Console.ReadKey();
        }

        static void MoveAnimal(IAnimal animal)
        {
            animal.Move();
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move() {
            Console.WriteLine("I'm moving");
        }

        public void Bark() {
            Console.WriteLine("Bark, Bark..");
        }
    }

}
