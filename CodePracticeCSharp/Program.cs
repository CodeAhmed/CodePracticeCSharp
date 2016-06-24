using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Number to find if its Even or Odd");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Number {0} is Even Number", number);
            else
                Console.WriteLine("Number {0} is Odd Number", number);
        }
    }
}
