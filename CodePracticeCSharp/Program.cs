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
            int number, sum = 0, digit, numbercopy;
            Console.WriteLine("Enter number to get the Sum of its Digits :");
            number = int.Parse(Console.ReadLine());
            numbercopy = number;
            while (number != 0)
            {
                digit = number % 10;
                number = number / 10;
                sum = sum + digit;
            }
            Console.WriteLine("The Sum of Digits of the Number {0}: ", sum);
            Console.ReadLine();
        }
    }
}
