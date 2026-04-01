using System;

namespace Object_Oriented_Programming_Lab
{
    internal class student  
    {
        public  string _name{get; set;}
        public int _rollNumber{get; set;}
        public  double _marks {get; set;}

        public student (string name, int rollNumber, double marks)
        {
            this._name = name;
            this._rollNumber=rollNumber;
            this._marks= marks;     
        }
        // copy constructor 
        public student(student ex)
        {
            _name = ex._name;
            _rollNumber = ex._rollNumber;
            _marks = ex._marks;
        }

        public void getdetails()
        {
            Console.WriteLine($" Student Name: {_name} ID: {_rollNumber} Marks: {_marks}");

        }



            


    }
    internal class program
    {
        public static void Main()
        {
            student s1 = new student("Hussain", 12, 89);
            s1.getdetails();

            // shallow copy
            student s2 = s1;
            s2.getdetails();

            // deep copy 
            student s3 = new student(s1);
            s3.getdetails();
        }
    }
}
