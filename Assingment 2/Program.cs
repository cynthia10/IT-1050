using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment22
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p1 = new Person();

            System.Console.Write("[  Information for p1 ]");
            System.Console.ReadLine();

            System.Console.Write("enter your FirstName      :");
            p1.FirstName = System.Console.ReadLine();

            System.Console.Write("enter your LasttName    :");
            p1.LastName = System.Console.ReadLine();

            System.Console.Write(p1.GetFullName());
            System.Console.ReadLine();

            System.Console.Write("Enter Your Age          : ");
            p1.Age = int.Parse(Console.ReadLine());

            p1.Spouse = new Person();

            System.Console.Write("enter your Spouse's FirstName    :");
            p1.Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("enter your Spouse's LastName     : ");
            p1.Spouse.LastName = System.Console.ReadLine();

            System.Console.Write(p1.Spouse.GetFullName());
            System.Console.ReadLine();

            System.Console.Write("Enter Your spouse's Age      : ");
            string input = System.Console.ReadLine();
            p1.Spouse.Age = Convert.ToInt32(input);



            Person p2 = new Person();

            System.Console.Write("[ Information for p2 ]");
            System.Console.ReadLine();

            System.Console.Write("enter your FirstName         :");
            p2.FirstName = System.Console.ReadLine();

            System.Console.Write("enter your LasttName         :");
            p2.LastName = System.Console.ReadLine();

            System.Console.Write(p2.GetFullName());
            System.Console.ReadLine();

            System.Console.Write("Enter Your Age                : ");
            p2.Age = int.Parse(Console.ReadLine());


            p2.Spouse = new Person();

            System.Console.Write("enter your Spouse's FirstName   :");
            p2.Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("enter your Spouse's LastName    : ");
            p2.Spouse.LastName = System.Console.ReadLine();

            System.Console.Write(p2.Spouse.GetFullName());
            System.Console.ReadLine();

            System.Console.Write("Enter Your spouse's Age         : ");
            string zero = System.Console.ReadLine();
            p2.Spouse.Age = Convert.ToInt32(zero);

            System.Console.Write("[priting results]");
            System.Console.ReadLine();

            p1.PrinNameAndAge();
            p1.Spouse.PrinNameAndAge();

            p2.PrinNameAndAge();
            p2.Spouse.PrinNameAndAge();

            Person.SumOfAllAges += p2.Spouse.Age; 
              Convert.ToInt32(zero);
            System.Console.ReadLine();

            Person.SumOfAllAges += p1.Spouse.Age;
            p1.Age = Convert.ToInt32(zero);
            System.Console.ReadLine();

            Person.SumOfAllAges+=p1.Age;
            p2.Spouse.Age = Convert.ToInt32(zero);
            System.Console.ReadLine();

            Person.SumOfAllAges+=p2.Age;
            p2.Age = Convert.ToInt32(zero);
            System.Console.ReadLine();


            Person.SumOfAllAges++;
            p2.Spouse.Age = Convert.ToInt32(zero);
            System.Console.ReadLine();

            Person.SumOfAllAges++;
            p2.Spouse.Age = Convert.ToInt32(zero);
            System.Console.ReadLine();


            System.Console.WriteLine(("Persons  :" + Person.SumOfAllAges / 4));
            System.Console.ReadLine();
            /*Person.SumOfAllAges = Double.Parse(Console.ReadLine());
           System.Console.ReadLine();*/

            System.Console.Write("press any key to continues");
            System.Console.ReadKey();

 
        }


    }
}
