using System;

namespace Example1._84
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        public class MyArgs : EventArgs
        { 
            public MyArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }

        public class Pub
        {
            public event EventHandler<MyArgs> OnChange = delegate { };

            public void Raise()
            {
                OnChange(this, new MyArgs(42));
            }
        }

        public static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (sender, e) =>
                {
                    Console.WriteLine("Event raised: {0}", e.Value);
                };
            p.Raise();
        }
    }
}
