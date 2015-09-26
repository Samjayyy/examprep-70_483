using System;

namespace Example1._96
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeOrder();
        }

        public static void MakeOrder()
        {
            try
            {
                // Error occurs
                throw new Exception("inner exception");
            }
            catch (Exception ex)
            {
                throw new OrderProcessingException("Error while proccesing order", ex);
            }
        }
    }
}
