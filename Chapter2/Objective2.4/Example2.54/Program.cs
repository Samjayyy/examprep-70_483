using System;
using System.Collections.Generic;

namespace Example2._54
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>
            {
            new Order { Created = new DateTime(2015, 4, 1 )},
            new Order { Created = new DateTime(2015, 1, 10 )},
            new Order { Created = new DateTime(2015, 2, 20 )},
            new Order { Created = new DateTime(2015, 2, 5 )},
            };
            Console.WriteLine("Before sort");
            orders.ForEach(Console.WriteLine);

            Console.WriteLine("-------------");
            orders.Sort();

            Console.WriteLine("After sort");
            orders.ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }

    class Order : IComparable, IComparable<Order>
    {
        public DateTime Created { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Order other = obj as Order;
            if (other == null)
            {
                throw new ArgumentException("Object is not an Order");
            }
            return CompareTo(other);
        }

        public int CompareTo(Order other)
        {
            return Created.CompareTo(other.Created);
        }



        public override string ToString() => Created.ToShortDateString();
    }
}
