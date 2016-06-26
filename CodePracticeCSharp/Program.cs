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
            int number, reverse = 0;
            Console.WriteLine("Enter any Number to find the reverse");
            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = ((number % 10) + reverse);
                number = number / 10;
                
            }
            Console.WriteLine("The reverse of the digits of the number is " + reverse);


        }
    }
}
