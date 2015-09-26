using System.Collections.Generic;

namespace Example2._43
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IRepository<T>
    {
        T FIndById(int id);

        IEnumerable<T> All();
    }

    class StringRepository : IRepository<string>
    {
        public string FIndById(int id)
        {
            return "42";
        }

        public IEnumerable<string> All()
        {
            return new List<string>() { "42", "3.14" };
        }
    }

    class DoubleReposiotry : IRepository<double>
    {
        public double FIndById(int id)
        {
            return 42d;
        }

        public IEnumerable<double> All()
        {
            return new List<double>() { 42d, 3.14 };
        }
    }
}
