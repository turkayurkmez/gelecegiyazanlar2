using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = getNumber();

            var anonType = new { Name="Türkay", LastName ="Ürkmez",  IsActivePerson = true };
            double pi = 3.14;
            var same = 3.14;

            var result = getNumber();
            Console.WriteLine(result.Number1);

            var products = new List<Product>
            {
                new Product { Id=1, Name="Product A", Price=10, Description="sddsddsd"},
                new Product { Id=2, Name="Product B", Price=10, Description="dfsdfsfsf"},
                new Product { Id=3, Name="Product C", Price=10, Description="skdjfksjdf"},

            };

            var nameAndPrice = products.Select(p => new { Name = p.Name, Price = p.Price });
            foreach (var anonym in nameAndPrice)
            {
                Console.WriteLine(anonym.Name + " " + anonym.Price);
            }


        }

        private static dynamic getNumber()
        {
            return new { Number1 = 9, Number2 = 3 };
        }
    }
}
