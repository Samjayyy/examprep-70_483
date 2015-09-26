using System;
using System.Runtime.Serialization;

namespace Example1._96
{
    public class OrderProcessingException : Exception, ISerializable
    {
        public OrderProcessingException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
