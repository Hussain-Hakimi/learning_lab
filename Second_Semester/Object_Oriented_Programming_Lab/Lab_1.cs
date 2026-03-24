using System;
class Lab_1
{
    public static void Main(string[] args)
    {
        Problem8();

    }
    static void First10problems()

    {   // This program swaps two numbers entered by the user
        int num1, num2, t;
        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        t = num1;
        num1 = num2;
        num2 = t;

        Console.WriteLine("After swapping:");
        Console.WriteLine("First number: " + num1);
        Console.WriteLine("Second number: " + num2);


        // Multiply Three Numbers
        int num3, result;
        Console.Write("Input the first number to multiply: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the second number to multiply: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input the third number to multiply: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        result = num1 * num2 * num3;

        Console.WriteLine($"{num1} x {num2} x {num3} = {result}");
    }

    public static void Problem8()
    {
        Console.WriteLine("Please Enter a number that i create a Multiplication Table of it");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int mul = 1; mul <=10; mul++)
        {
            Console.WriteLine($" {mul} x {num} = {mul* num} ");
        }
            
    }

    




    
}
