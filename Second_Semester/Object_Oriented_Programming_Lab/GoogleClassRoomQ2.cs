using System;

class Employee
{
    private int _employeeId;
    private string _employeeName;
    private double _basicSalary;

    // Getter & Setter methode for EmployeeId
    public int GetEmployeeId()//getter method to retrieve the employee ID
    {
        return _employeeId;
    }


    // setter method to set the employee ID with validation
    public void SetEmployeeId(int id)
    {
        if (id > 0)
        {
            _employeeId = id;
        }
        else
        {
            Console.WriteLine("Invalid Employee ID!");
        }
    }

    // Getter & Setter for EmployeeName

    public string GetEmployeeName()
    {
        return _employeeName;
    }

    // setter method to set the employee name with valedation
    // these validation is to ensure that the name is not null or empty, which helps maintain data integrity and prevents potential issues when working with employee names in the future.


    public void SetEmployeeName(string name)
    {
        if (!string.IsNullOrEmpty(name))
        {
            _employeeName = name;
        }
        else
        {
            Console.WriteLine("Invalid Name!");
        }
    }

    // Getter & Setter for BasicSalary
    public double GetBasicSalary()
    {
        return _basicSalary;
    }


    // this is setter method to set the basic salary .
    public void SetBasicSalary(double salary)
    {
        if (salary >= 20000)
        {
            _basicSalary = salary;
        }
        else
        {
            Console.WriteLine("Salary must be at least 20,000!");
        }
    }

    // instance method to calculate the net Salary 
    public double CalculateNetSalary()
    {
        double allowance = _basicSalary * 0.10;
        double salaryWithAllowance = _basicSalary + allowance;

        double tax = salaryWithAllowance * 0.05;
        double netSalary = salaryWithAllowance - tax;

        return netSalary;
    }


    // main method to test the Employee class


    class Program
    {
        static void Main()
        {
            Employee employ = new Employee();

            employ.SetEmployeeId(1);
            employ.SetEmployeeName("Ali");
            employ.SetBasicSalary(30000);

            Console.WriteLine($"ID:  {employ.GetEmployeeId()}");
            Console.WriteLine($"Name:  {employ.GetEmployeeName()}");
            Console.WriteLine($"Basic Salary: {employ.GetBasicSalary()}");
            Console.WriteLine($"Net Salary: {employ.CalculateNetSalary()}");
        }
    }
}