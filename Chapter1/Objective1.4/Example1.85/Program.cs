using System;

namespace Example1._85
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

        static void OnChange(object sender, Program.MyArgs e)
        {
            Console.WriteLine("OnChange HIT");
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
            private event EventHandler<MyArgs> onChange = delegate { };

            public event EventHandler<MyArgs> OnChange
            { 
                add
                {
                    lock (onChange)
                    {
                        onChange += value;
                    }
                }
                remove
                {
                    lock(onChange)
                    {
                        onChange -= value;
                    }
                }
            }

            public void Raise()
            {
                onChange(this, new MyArgs(42));
            }
        }
    }
}
