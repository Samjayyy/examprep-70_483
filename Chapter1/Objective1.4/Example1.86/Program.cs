using System;

namespace Example1._86
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, EventArgs.Empty);
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) =>
                {
                    Console.WriteLine("Subscrober 1 called");
                };
            p.OnChange += (sender, e) =>
                {
                    { 
                        throw new Exception(); 
                    }
                };
            p.OnChange += (sender, e) =>
                {
                    Console.WriteLine("Subscriber 3 called"); // Is never called
                };

            p.Raise();
        }
    }
}
