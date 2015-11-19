using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int temp;
            Console.WriteLine("Please enter 2 sides of a rectangle.");
            Console.WriteLine("Enter side A: ");
            try
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side B: ");
                b = int.Parse(Console.ReadLine());
                temp = a * b;
                Console.WriteLine("Here is your result: " + temp);

            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid informaton!");
            }
        }
    }
}
