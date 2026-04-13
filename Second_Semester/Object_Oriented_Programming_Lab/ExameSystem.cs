using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Lab
{
    internal class Exame

    {
        public string Text { get; set; }
        public double Marks { get; set; }
        public string Answer { get; set; }

        public Exame(string text)
        {
            Text = text;
        }
        public Exame(string text, double marks)
        {
            Text = text;
            Marks = marks;
        }
        public Exame(string text, double marks, string answer)
        {
            Text = text;
            Marks = marks;
            Answer = answer;
        }
        public void Display()
        {
            Console.WriteLine("Question: " + Text);
            Console.WriteLine("Marks: " + Marks);
            Console.WriteLine("Answer: " + Answer);
        }
    }
    //public class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Exame q1 = new Exame("What is OOP?", 5, "Object-Oriented Programming");
    //        Exame q2 = new Exame("What is Encapsulation?", 5);
    //        Exame q3 = new Exame("What is Inheritance?");
    //        q1.Display();
    //        Console.WriteLine();
    //        q2.Display();
    //        Console.WriteLine();
    //        q3.Display();
    //    }
    }
}
