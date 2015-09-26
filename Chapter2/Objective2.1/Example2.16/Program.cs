using System;

namespace Example2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product() { Price = 1000 };
            var calc = new Calculator();
            Console.WriteLine("Discount of {0} is {1}", p.Price, calc.CalculateDiscount(p));

            var clone = p.CloneProductWithDiscount();
            Console.WriteLine($"Price of cloned product is: {clone.Price}");

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    public class Product
    {
        public decimal Price { get; set; }
    }

    public static class MyExtensions
    {
        public static decimal Discount(this Product product)
        {
            return product.Price * .9M;
        }

        public static T CloneProductWithDiscount<T>(this T product) where T : Product, new()
        {
            T copy = new T();
            copy.Price = product.Discount();
            return copy;
        }

    }

    public class Calculator
    {
        public decimal CalculateDiscount(Product p)
        {
            return p.Discount();
        }
    }
}
