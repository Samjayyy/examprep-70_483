
namespace Example2._6
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        public Distance CalculateDistanceTo(Address address)
        {
            Distance result = new Distance(address.Distance);

            return result;
        }
    }

    public class Distance
    {
        public Distance(double distance)
        {
            this.Value = distance;
        }

        public double Value { get; set; }
    }

    public class Customer
    {
        public Address Address { get; set; }
    }

    public class Address
    {
        public double Distance { get; set; }
    }
}
