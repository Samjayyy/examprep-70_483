using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Example1._98
{
    public class OrderProcessingExcpetion : Exception, ISerializable
    {
        public OrderProcessingExcpetion(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/InformationAboutException";
        }

        public OrderProcessingExcpetion(int orderId, string message)
            : base(message)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/InformationAboutException";
        }

        public OrderProcessingExcpetion(int orderId, string message, Exception innerException)
            : base(message, innerException)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/InformationAboutException";
        }

        protected OrderProcessingExcpetion(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("OrderId", typeof(int));
        }

        public int OrderId { get; private set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("OrderId", OrderId, typeof(int));
        }
    }
}
