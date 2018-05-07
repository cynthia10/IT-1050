using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = -1;
            while (input < 0)
            {
                input = Question.AskForInterger("enter a positive number");
            }

            for (int i = 0; i < 10; i++)//continuation asking the ussre the cordinate
            {
                System.Console.WriteLine(i);
            }
            for (int num=30;num>=20;num--)
            {
                System.Console.WriteLine(num);
            }
        }

    }
}
