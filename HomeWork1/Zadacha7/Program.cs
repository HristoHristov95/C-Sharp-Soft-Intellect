using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            float a1;
            double b1;
            String ss;
            Console.WriteLine("Please enter a number of your desire: ");
            ss = Console.ReadLine();
            try
            {
                if (int.TryParse(ss, out a))
                {
                    a = int.Parse(ss);
                    Console.WriteLine("Now enter number of Type INT !");
                    int temp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (a / temp));
                }
                if (float.TryParse(ss, out a1))
                {
                    a1 = float.Parse(ss);
                    Console.WriteLine("Now enter number of Type INT !");
                    int temp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (a1 / temp));
                }
                if (double.TryParse(ss, out b1))
                {
                    b1 = double.Parse(ss);
                    Console.WriteLine("Now enter number of Type INT !");
                    int temp = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (b1 / temp));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Do you even listen to me ?");
            }
        }
    }
}
