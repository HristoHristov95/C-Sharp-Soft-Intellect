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
            Console.WriteLine("Enter the number N :");
            int temp = int.Parse(Console.ReadLine());
            for(int i=1;i<=temp;i++)
            {
                if((i%3 != 0) && (i%7 != 0))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
