using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // qestion  1.	Write a program to declare variables of type int, double, char, and string. Assign values and print them.
            Console.WriteLine("question number 1");
            int myNum = 12;
            double Mydouble = 19.9;
            char first_letter= 'A';
            string Name = "Hussain";
            Console.WriteLine(myNum);
            Console.WriteLine(Mydouble);
            Console.WriteLine(first_letter);
            Console.WriteLine(Name);

            // qestion 2.	Take two integers from user input and print their sum, difference, multiplication, and division.
            Console.WriteLine("question number 2");
            Console.WriteLine("wrtie a your first number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("write your seconde number: ");
            int number2= Convert.ToInt32(Console.ReadLine());
            int Sum= number + number2;
            Console.WriteLine(Sum);
            int difference= number - number2;
            Console.WriteLine(difference);
            int multiple= number * number2;
            Console.WriteLine(multiple);
            double division= number / number2;
            Console.WriteLine(division);

            //question 3.	Write a program that converts a double value into int using explicit casting. Display both values.
            Console.WriteLine("question number 3");
            double d = 23.455;
            int MyIntiger= (int) d;
            Console.WriteLine(d);
            Console.WriteLine(MyIntiger);

            // question 4.	Take a number as string input and convert it into an integer. Handle invalid input.
            Console.WriteLine("question number 4");
            Console.WriteLine("Enter a number ");
            string My_num=Console.ReadLine();
            Console.WriteLine(My_num);
            int my_intiger = Convert.ToInt32(My_num);
            Console.WriteLine(my_intiger);

            // quesion number 5.	Write a program to calculate the area of a circle using double datatype.
            Console.WriteLine("queston number 5");
            Console.WriteLine("Enter the radius of the circle");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("____________________________calculation_______________________________");
            Console.WriteLine("radius =  " + radius);
            double Area = 3.14 * (radius * radius);
            Console.WriteLine("the Area=   " + Area);

            // question number 6.	Write a program to check whether a number is positive, negative, or zero.
            Console.WriteLine("_______________________________________________________________________");
            int num3 = 32;
            if ((int)num3 > 0)
            { Console.WriteLine("Positive"); }
            else if ((int)num3 < 0)
            { Console.WriteLine("Nigative"); }
            else 
            { Console.WriteLine("zero"); }

            // question number 7.	Take age as input and determine whether the person is eligible to vote.
            Console.WriteLine("___________________________________________________________________________");
            Console.WriteLine("Please write your age:  ");
            int age= Convert.ToInt32(Console.ReadLine());
            if ((int)age >= 18) { Console.WriteLine("You are eligible to vote"); }
            else { Console.WriteLine("Sorry your are not eligible "); }

            // question number 8.    Write a program to check whether a number is even or odd using the ternary operator.
            Console.WriteLine("__________________________________________________________________________-");
            Console.WriteLine("Enter a number : ");
            int myNumber = Convert.ToInt32(Console.ReadLine());
            string result = (myNumber % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(result);

            // question number 9.	Take three numbers and print the largest one using if-else statements.

            Console.WriteLine("Enter first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your third number: ");
            int third_number = Convert.ToInt32(Console.ReadLine());

            int largest;
            if (first_number >= second_number && first_number >= third_number)
            {
                largest = first_number;
            }
            else if (second_number >= first_number && second_number >= third_number)
            {
                largest = second_number;
            }
            else
            {
                largest = third_number;
            }

            Console.WriteLine("The largest number is: " + largest);
        }
    }
}
