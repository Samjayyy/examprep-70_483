using System;
using System.Collections.Generic;
using System.Linq;

namespace Example2._46
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new OrderRepository(Enumerable.Range(1,10).Select(i => new Order(i)));
            var secondOrder = repository.FindById(2);
            Console.WriteLine($"secondOrder.Id is {secondOrder.Id}");

            IEnumerable<Order> filteredOrders = repository.FilterOnOddIds();
            Console.WriteLine($"Filtered Odd: {string.Join(", ",filteredOrders)}");

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    interface IEntity
    {
        int Id { get; }
    }

    class Repository<T>
        where T : IEntity
    {
        protected IEnumerable<T> elements;

        public Repository(IEnumerable<T> elements)
        {
            this.elements = elements;
        }

        public T FindById(int id)
        {
            return this.elements.SingleOrDefault(e => e.Id == id);
        }
    }

    class Order : IEntity
    {
        public Order(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }

        public override string ToString()
        {
            return $"Id: {Id}";
        }
        // Other implementation details omitted
        // ...
    }

    class OrderRepository : Repository<Order>
    {
        public OrderRepository(IEnumerable<Order> orders)
            : base(orders) { }

        public IEnumerable<Order> FilterOnOddIds()
        {
            return elements.Where(o => (o.Id & 1) == 1); // Filtering out where LSB is 1
        }

    }
}
