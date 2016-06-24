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
            int first, second, temp = 0;
            string choice="Y";
            while(choice=="Y" || choice=="y")
            {
                Console.WriteLine("Enter First Number : ");
                first = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number : ");
                second = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Before Swapping");
                Console.WriteLine("First Number - " + first +": Second Number - " + second);
                temp = first;
                first = second;
                second = temp;
                Console.WriteLine("After Swapping");
                Console.WriteLine("First Number - " + first + ": Second Number - " + second);
                Console.WriteLine("Would you like to Continue..... Y or N");
                choice = Console.ReadLine();
                
            }
            
        }
    }
}
