using System;
using System.Collections.Generic;

namespace Example2._43
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository<string> repo = new StringRepository();
            Console.WriteLine($"All strings: {string.Join(", ", repo.All())}");

            //repo = new DoubleReposiotry(); // not possible
            var repo2 = new DoubleReposiotry();
            Console.WriteLine($"All doubles: {string.Join(", ", repo2.All())}");

            Console.ReadKey();
        }
    }

    interface IRepository<T>
    {
        T FindById(int id);

        IEnumerable<T> All();
    }

    class StringRepository : IRepository<string>
    {
        public string FindById(int id)
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
        public double FindById(int id)
        {
            return 42d;
        }

        public IEnumerable<double> All()
        {
            return new List<double>() { 42d, 3.14 };
        }
    }
}
