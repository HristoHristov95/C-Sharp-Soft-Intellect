using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            String s;
            Console.WriteLine("Please enter String: ");
            s = Console.ReadLine();
            Console.WriteLine("Now enter number of a char in the String: ");
            try
            {
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Result : " + s.ElementAt(a));
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Invalid information !");
            }catch(System.ArgumentOutOfRangeException e)
            {
                Console.WriteLine("The number of the symbol you want is not in the bounds of the String!");
            }
        }
    }
}
