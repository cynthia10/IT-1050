using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment22
{
    class Person
    {

        public string FirstName;
        public string LastName;
        public Person Spouse;
        public int Age;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrinNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + "," + this.LastName + " ," + (this.Age));
        }
        public static void GetSumOfAllAges()
        {
            System.Console.WriteLine("Get Sum Of All Ages/4");

        }

    }
}
