using System;
using System.Collections.Generic;

namespace Object_Oriented_Programming_Lab
{
    internal class Department
    {
        // Property that holds a list of employees
        public List<string> Employees { get; set; }

        // Constructor that initializes the list from an existing list
        public Department(List<string> employees)
        {
            // Shallow copy of the list reference (the original list is shared)
            Employees = employees;
        }

        // Copy constructor for DEEP copy
        public Department(Department other)
        {
            // Deep copy: create a new list containing the same elements
            Employees = new List<string>(other.Employees);
        }

        // Override ToString to show employee list
        public override string ToString()
        {
            return "[" + string.Join(", ", Employees) + "]";
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Create initial list of employees
            List<string> initialEmployees = new List<string> { "Ahmed", "Ali", "Mohamed" };

            // Create Department d1 using the list
            Department d1 = new Department(initialEmployees);
            Console.WriteLine("Original d1: " + d1);

            // SHALLOW COPY: d2 references the same Department object as d1
            Department d2 = d1;
            // Modify the Employees list through d2 (which is the same list as d1)
            d2.Employees.Add("Hussain");
            Console.WriteLine("\nAfter shallow copy and adding 'Hussain' via d2:");
            Console.WriteLine("d1: " + d1);   // d1 sees the change because list is shared
            Console.WriteLine("d2: " + d2);

            // DEEP COPY: d3 is a new Department object with its own list copy
            Department d3 = new Department(d1);
            // Modify d3's list – this should NOT affect d1
            d3.Employees.Add("Omar");
            Console.WriteLine("\nAfter deep copy and adding 'Omar' via d3:");
            Console.WriteLine("d1: " + d1);   // unchanged
            Console.WriteLine("d3: " + d3);   // has the new employee
        }
    }
}