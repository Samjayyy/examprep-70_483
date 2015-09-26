
namespace Example2._44
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();
            //animal.Bark(); This will thrown an compile error
            (animal as Dog).Bark(); // Is allowed
        }
    }

    interface IAnimal
    {
        void Move();
    }

    class Dog : IAnimal
    {
        public void Move() { }

        public void Bark() { }
    }

}
