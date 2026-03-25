using System;

class StudentRecord
{
    private int _studentId;
    private string _studentName;
    private double _marks;
    private bool _isPassedLocked = false;  // this don't allow marks to be changed after passing

    // Constructor that initializes student ID and name .
    public StudentRecord(int id, string name)
    {
        _studentId = id;
        _studentName = name;
    }

    // Getters for student ID, name, and marks 
    public int GetStudentId()
    {
        return _studentId;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public double GetMarks()
    {
        return _marks;
    }

    // Setter with rules that apply incapsuation to marks 
    public void SetMarks(double marks)
    {
        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid marks!");
            return;
        }

        if (_isPassedLocked)
        {
            Console.WriteLine("Marks cannot be changed after passing!");
            return;
        }

        _marks = marks;

        if (_marks > 40)
        {
            _isPassedLocked = true;
        }
    }

    // Grade method that returns the grade based on the marks 
    public string GetGrade()
    {
        if (_marks >= 80)
        {
            return "A";
        }
        else if (_marks >= 60)
        {
            return "B";
        }
        else if (_marks >= 40)
        {
            return "C";
        }
        else
        {
            return "F";
        }
    }
}
//  Main program for  test the StudentRecord class and demonstrate encapsulation and data hiding
class Program
{
    static void Main()
    {
        StudentRecord s = new StudentRecord(3, "Hussain Hakimi");

        s.SetMarks(35);  
        s.SetMarks(75);  
        s.SetMarks(90);  

        Console.WriteLine("ID: " + s.GetStudentId());
        Console.WriteLine("Name: " + s.GetStudentName());
        Console.WriteLine("Marks: " + s.GetMarks());
        Console.WriteLine("Grade: " + s.GetGrade());
    }
}