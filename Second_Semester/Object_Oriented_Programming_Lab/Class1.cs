using System;
using System.Collections.Generic;

public class Students
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Marks { get; set; }

    public Students(int id, string name, double marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
}

public class Program
{
    static List<Student> students = new List<Student>();

    public static void AddStudent(int id, string name, double marks)
    {
        students.Add(new Students(id, name, marks));
    }

    public static void DisplayAll()
    {
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Marks}");
        }
    }

    public static void HighestMarks()
    {
        double max = students.Max(s => s.Marks);
        var top = students.First(s => s.Marks == max);

        Console.WriteLine($"Top: {top.Name} with {top.Marks}");
    }
}