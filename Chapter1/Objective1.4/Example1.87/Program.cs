using System;
using System.Collections.Generic;
using System.Linq;

namespace Example1._87
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAndRaise();

            Console.Write("Press a key to exit");
            Console.ReadKey();
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
                Console.WriteLine("Subscriber 3 called");
            };

            try
            {
                p.Raise();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("{0} exceptions caught", ex.InnerExceptions.Count);
            }
        }

        public class Pub
        {
            public event EventHandler OnChange = delegate { };

            public void Raise()
            {
                var exceptions = new List<Exception>();
                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }

                    if (exceptions.Any())
                    {
                        throw new AggregateException(exceptions);
                    }
                }
            }
        }
    }
}
