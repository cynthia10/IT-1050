using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Instructor
    {

        private string Name;
        private string CourseName;



        public void SetStudentGrade(Student Student, int grade)

        {
            Student.SetGrade(grade);
        }

        public void Print()
        {
            System.Console.WriteLine("Teacher name" + this.Name);
            System.Console.WriteLine("Teachercourse" + this.CourseName);
        }
        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }
    }
}

