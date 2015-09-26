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
            new Order { Created = new DateTime(2012, 12, 1 )},
            new Order { Created = new DateTime(2012, 1, 6 )},
            new Order { Created = new DateTime(2012, 7, 8 )},
            new Order { Created = new DateTime(2012, 2, 20 )},
            };
            Console.WriteLine("Before sort");
            PrintOrders(orders);
            orders.Sort();
            Console.WriteLine("After sort");
            PrintOrders(orders);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }

        private static void PrintOrders(List<Order> orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine(order.Created.ToString());
            }
        }
    }

    class Order : IComparable
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

            return this.Created.CompareTo(other.Created);
        }
    }
}
