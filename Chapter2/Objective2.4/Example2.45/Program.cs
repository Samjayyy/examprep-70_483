using System.Collections.Generic;
using System.Linq;

namespace Example2._45
{
    class Program
    {
        static void Main(string[] args)
        {
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
}
