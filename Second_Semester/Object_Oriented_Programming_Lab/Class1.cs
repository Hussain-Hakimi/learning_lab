using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pruduct
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    private decimal _price;
    public decimal Price
    {
        get { return _price; }
        set
        {
            if (value >= 0)
            {
                _price = value;
            }
            else
            {
                Console.WriteLine("Price cannot be negative.");
            }
        }
    }

    public Pruduct(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}

public class Managments
{
    public static List <Pruduct> ProductList= new List<Pruduct>();

    public static void AddProduct(Pruduct p)
    {
        ProductList.Add(p);
    }
    public static void DisplayAll()
    {
        foreach (var p in ProductList)
        {
            Console.WriteLine(p.Name);
        }
    }

    public static void FindWithLowestPrice()
    {
        decimal min = ProductList.Min(p => p.Price);
        var cheapest = ProductList.First(p => p.Price == min);
        Console.WriteLine($"Cheapest: {cheapest.Name} with {cheapest.Price:C}");
    }
}