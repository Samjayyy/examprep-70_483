using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Example3._1
{
    [MetadataType(typeof(Customer))]
    class Program
    {
        static void Main(string[] args)
        {
            // OBJECT TO VALIDATE
            Address a = new Address()
            {
                Id = 1
            };
            Customer c = new Customer()
            {
                FirstName = "Samwiser",
                LastName = string.Empty,
                BillingAddress = a,
            };

            Validate(c);

            Console.ReadKey();
        }

        private static void Validate(Customer customer){
            // CALL VALIDATION
            var results = new List<ValidationResult>();
            if (AppendValidation(customer, results))
            {
                Console.WriteLine("Validation succeeded.");
            }
            else
            {
                Console.WriteLine("Error during validation:");
            }

            // PRINT RESULTS
            if (results.Any())
            {
                results.ForEach(Console.WriteLine);
            }
        }

        private static bool AppendValidation(object obj, List<ValidationResult> results, bool allowNull = true)
        {
            if (obj == null) return allowNull;
            var ctx = new ValidationContext(obj);
            return Validator.TryValidateObject(obj, ctx, results);
        }
    }

    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public Address ShippingAddress { get; set; }

        [Required]
        public Address BillingAddress { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
    }
    
}
