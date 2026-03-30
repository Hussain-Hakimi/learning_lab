using System;

namespace Object_Oriented_Programming_Lab
{
    internal class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string FuelType { get; set; }

        // Constructor when only model is provided
        public Car(string model)
        {
            Model = model;
            Price = 0.00m;
            FuelType = "Unknown";
        }

        // Constructor when model and price are provided
        public Car(string model, decimal price)
        {
            Model = model;
            Price = price;
            FuelType = "Unknown";
        }

        // Constructor when model, price, and fuel type are provided
        public Car(string model, decimal price, string fuelType)
        {
            Model = model;
            Price = price;
            FuelType = fuelType;
        }

        // Method to display car details
        public string GetCarDetails()
        {
            return $"Model: {Model}, Price: {Price:C}, Fuel Type: {FuelType}";
        }
    }

    public class Program1
    {
        static void Main()
        {
            // Creating Car objects using different constructors
            Car car1 = new Car("Toyota Corolla");               // Only model → calls single‑parameter constructor
            Car car2 = new Car("Honda Civic", 25000.00m);       // Model + price → calls two‑parameter constructor
            Car car3 = new Car("Tesla Model 3", 45000.00m, "Electric"); // All three → calls three‑parameter constructor

            // Display details
            Console.WriteLine(car1.GetCarDetails());
            Console.WriteLine(car2.GetCarDetails());
            Console.WriteLine(car3.GetCarDetails());

            // Explanation of which constructor is called for car1
            Console.WriteLine("\nWhen only the model is provided (car1), the constructor with a single string parameter is called.");
            Console.WriteLine("The compiler matches the number and type of arguments to the most appropriate constructor.");
        }
    }
}