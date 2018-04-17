using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Student
    {

        private string Name;
        private int Grade;
        private Instructor Teacher;



        public void Print()
        {
            System.Console.WriteLine("student nam " + this.Name);
            System.Console.WriteLine(" grade was " + this.Grade);
            this.Teacher.Print();
        }

        public void SetGrade(int z)
        {
            this.Grade = z;

        }
        public Student(int theirgrade)
        {
            this.Grade = theirgrade;
        }

        public Student(string Name, Instructor Teacher)
        {
            this.Name = Name;
            this.Teacher = Teacher;
        }




    }
}
