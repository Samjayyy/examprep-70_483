using System;

namespace Example1._83
{
    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.OnChange += OnChange;
            p.Raise();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public static void OnChange()
        {
            Console.WriteLine("Event raised");
        }

        private class Pub
        {
            public event Action OnChange = delegate { };

            public void Raise()
            {
                OnChange();
            }
        }
    }
}
