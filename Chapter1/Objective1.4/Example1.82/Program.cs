using System;

namespace Example1._82
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
            public Action OnChange { get; set; }

            public void Raise()
            {
                if (OnChange != null)
                {
                    OnChange();
                }
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += () =>
                {
                    Console.WriteLine("Event raised to method 1");
                };
            p.OnChange += () =>
                {
                    Console.WriteLine("Event raise to method 2");
                };
            p.Raise();
        }
    }
}
