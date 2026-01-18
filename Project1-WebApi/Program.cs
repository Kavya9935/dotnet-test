using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Project1_WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Mouse", Price = 29.99m }
            };
            
            string json = JsonConvert.SerializeObject(products);
            Console.WriteLine(json);
        }
    }
    
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
