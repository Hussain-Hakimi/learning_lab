using System;

public class Student
{
    // Private fields (encapsulated)
    private string _name;
    private int _rollNumber;
    private int _marks;

    // Public properties with validation
    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value), "Name cannot be null");
    }

    public int RollNumber
    {
        get => _rollNumber;
        set => _rollNumber = value;
    }

    public int Marks
    {
        get => _marks;
        set
        {
            // Validation: marks must be between 0 and 100 inclusive
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(value),
                    value,
                    "Marks must be between 0 and 100."
                );
            }
            _marks = value;
        }
    }

    // Constructor for easy initialization
    public Student(string name, int rollNumber, int marks)
    {
        Name = name;
        RollNumber = rollNumber;
        Marks = marks;  // Validation runs here too
    }

    // Method to display student details
    public string PrintDetails()
    {
        return $"Name: {Name}, Roll Number: {RollNumber}, Marks: {Marks}";
    }
}

public class Program
{
    public static void Main()
    {
        // Scenario 1: Valid marks (no exception)
        try
        {
            Student student1 = new Student("Hussain Hakimi", 12345, 85);
            Console.WriteLine("✅ Valid student created:");
            Console.WriteLine(student1.PrintDetails());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("\n--- Attempting invalid marks ---\n");

        // Scenario 2: Invalid marks (below 0)
        try
        {
            Student student2 = new Student("Ali Raza", 67890, -10); // Invalid
            Console.WriteLine(student2.PrintDetails()); // This line won't execute
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"❌ Invalid assignment caught:");
            Console.WriteLine($"   Error: {ex.Message}");
            Console.WriteLine($"   Attempted value: {ex.ActualValue}");
        }

        // Scenario 3: Invalid marks (above 100)
        try
        {
            Student student3 = new Student("Sara Khan", 11223, 150); // Invalid
            Console.WriteLine(student3.PrintDetails());
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"\n❌ Another invalid assignment:");
            Console.WriteLine($"   Error: {ex.Message}");
            Console.WriteLine($"   Attempted value: {ex.ActualValue}");
        }

        // Scenario 4: Changing marks of an existing student to invalid value
        try
        {
            Student student4 = new Student("Ahmed Ali", 44556, 75);
            Console.WriteLine($"\nBefore change: {student4.PrintDetails()}");

            student4.Marks = 200;  // This will throw
            Console.WriteLine("This line will not be printed.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"❌ After change attempt:");
            Console.WriteLine($"   {ex.Message}");
        }
    }
}