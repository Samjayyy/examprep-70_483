using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Example3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<ShopContext>());
            using (ShopContext ctx = new ShopContext())
            {
                Address a = new Address()
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };

                Customer c = new Customer()
                {
                    FirstName = "abcdefghijklmnopqrstuvwxyz",
                    LastName = "Doe",
                    BillingAddress = a,
                    ShippingAddress = a
                };

                ctx.Customers.Add(c);
                if (ctx.GetValidationErrors().Any())
                {
                    ctx.GetValidationErrors().SelectMany(e => e.ValidationErrors).Select(e => e.ErrorMessage).ToList().ForEach(Console.WriteLine);
                }
                else
                {
                    ctx.SaveChanges();
                    Console.WriteLine($"Customer saved: {c}");
                }
            }

            Console.ReadKey();
        }
    }

    public class ShopContext : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }

    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(20)]
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

        [Required]
        public string AddressLine1 { get; set; }

        [Required]
        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
        public string ZipCode { get; set; }
    }

    public static class GenericValidator<T>
    {
        public static IList<ValidationResult> Validate(T entity)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, context, results);

            return results;
        }
    }
}
