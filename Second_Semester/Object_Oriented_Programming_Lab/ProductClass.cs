using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Object_Oriented_Programming_Lab
{
    internal class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        // Constructor with all parameters
        public Product(string name, decimal price, int stockQuantity)
        {
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        // Constructor with name and price; stock defaults to 0
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            StockQuantity = 0;
        }

        // Constructor with only name; price and stock default to 0
        public Product(string name)
        {
            Name = name;
            Price = 0.00m;
            StockQuantity = 0;
        }

        // Optional: Constructor with a discount (example)
        public Product(string name, decimal originalPrice, int stockQuantity, decimal discountPercent)
        {
            Name = name;
            Price = originalPrice - (originalPrice * discountPercent / 100);
            StockQuantity = stockQuantity;
        }
    }

    class Program
    {
        public static void Test() 
        {
            // Creating 3 products using different constructors
            Product product1 = new Product("Laptop", 1200.00m, 10);

            Product product2 = new Product("Mouse", 25.99m);          // stock defaults to 0
            Product product3 = new Product("Keyboard");              // price and stock default to 0

            // Optional: product with discount
            Product product4 = new Product("Monitor", 300.00m, 5, 10); // 10% discount
        }
    }
}









