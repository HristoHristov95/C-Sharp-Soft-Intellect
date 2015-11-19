using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1, s2;
            Console.WriteLine("Enter 1-rst String: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter 2-cond String to check if this one is in the 1-rst: ");
            s2 = Console.ReadLine();
            if(s1.Contains(s2))
            {
                Console.WriteLine("Yes the second string you entered is in the first ! ");
            }
            else
            {
                Console.WriteLine("No the second string you entered is not in the first !");
            }
        }
    }
}
