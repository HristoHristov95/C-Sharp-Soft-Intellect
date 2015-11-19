using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("You must enter two numbers.");
            try
            {
                Console.WriteLine("Please enter number 1:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter number 2:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Here is number 1 : " + a);
                Console.WriteLine("Here is number 2 : " + b);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot conver String to an INT!");
            }
        }
    }
}
