using System;

namespace Example1._98
{
    class Program
    {
        static void Main(string[] args)
        {
            // Possible constructors to use with the custom OrderProcessingExcpetion
            var errorOrderId = 1;
            throw new OrderProcessingExcpetion(errorOrderId);
            throw new OrderProcessingExcpetion(errorOrderId, string.Format("Order {0} is incorrect.", errorOrderId));
            throw new OrderProcessingExcpetion(errorOrderId, string.Format("Order {0} is incorrect.", errorOrderId), new ArgumentNullException());
        }
    }
}
