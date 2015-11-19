using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("This program will take 2 numbers and will give (number A % number B) = Result !");
            Console.WriteLine("Enter A:");
            try
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number B:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + (a % b));
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid information !");
            }
        }
    }
}
