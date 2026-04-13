using System;

public class Car
{
    // Properties
    public string Model { get; private set; }
    public decimal Price { get; private set; }           // currency
    public double FuelEfficiency { get; private set; }   // e.g., km per liter or mpg

    // 1) General constructor: model + price + fuel efficiency
    public Car(string model, decimal price, double fuelEfficiency)
    {
        if (string.IsNullOrWhiteSpace(model)) throw new ArgumentException("Model required", nameof(model));
        if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
        if (fuelEfficiency <= 0) throw new ArgumentOutOfRangeException(nameof(fuelEfficiency));

        Model = model;
        Price = price;
        FuelEfficiency = fuelEfficiency;
    }

    // 2) Economy constructor: model only, uses economy defaults
    public Car(string model)
        : this(model, DefaultEconomyPrice, DefaultEconomyFuelEfficiency)
    {
    }

    // 3) Luxury constructor: model + luxury flag, uses luxury defaults
    public Car(string model, bool isLuxury)
        : this(model,
               isLuxury ? DefaultLuxuryPrice : DefaultEconomyPrice,
               isLuxury ? DefaultLuxuryFuelEfficiency : DefaultEconomyFuelEfficiency)
    {
    }

    // Default presets (could be moved to config)
    private const decimal DefaultEconomyPrice = 15000m;
    private const double DefaultEconomyFuelEfficiency = 18.0; // km/l

    private const decimal DefaultLuxuryPrice = 75000m;
    private const double DefaultLuxuryFuelEfficiency = 10.0; // km/l

    // Optional convenience factory methods
    public static Car CreateEconomy(string model) => new Car(model, DefaultEconomyPrice, DefaultEconomyFuelEfficiency);
    public static Car CreateLuxury(string model) => new Car(model, DefaultLuxuryPrice, DefaultLuxuryFuelEfficiency);

    public override string ToString()
    {
        return $"{Model} — Price: {Price:C0}, Fuel Efficiency: {FuelEfficiency} km/l";
    }
}

// Example usage
//class Program
//{
//    static void Main()
//    {
//        var generic = new Car("Compact X", 22000m, 16.5);
//        var economy = new Car("EcoMini");                 // uses economy defaults
//        var luxury = new Car("Luxora", true);             // uses luxury defaults

//        Console.WriteLine(generic);
//        Console.WriteLine(economy);
//        Console.WriteLine(luxury);
//    }
}
