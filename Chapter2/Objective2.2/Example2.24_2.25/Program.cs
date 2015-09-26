using System;

namespace Example2._24
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m = new Money(42.42M);
            decimal amount = m;
            int truncatedAmount = (int)m;

            Console.WriteLine($"amount = {amount}");
            Console.WriteLine($"truncatedAmount = {truncatedAmount}");

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }

    class Money
    {
        public Money(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; set; }

        public static implicit operator decimal(Money money)
        {
            return money.Amount;
        }

        public static explicit operator int(Money money)
        {
            return (int)money.Amount;
        }
    }
}
