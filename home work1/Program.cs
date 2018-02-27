using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleName;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeight;

            System.Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            System.Console.Write("Middle Name: ");
            string middleName = Console.ReadLine();
            System. Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            string fullName = firstName + " " + middleName + " " + lastName;

           System. Console.Write("Height in Feet: ");
            int heightFeet = int.Parse(Console.ReadLine());
            System.Console.Write("Height in Inches: ");
            double heightInches = double.Parse(Console.ReadLine());

            double heightCentimeters = (heightFeet * 12 + heightInches) * 2.54;

           System. Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
           System. Console.Write("Citizen? (y/n): ");
            bool isCitizen = Console.ReadLine().ToLower().StartsWith("y");

            bool canVote = isCitizen && age >= 18;

            System.Console.WriteLine(fullName);
            System.Console.WriteLine(heightCentimeters);
            System.Console.WriteLine(canVote);

        }
    }
}
