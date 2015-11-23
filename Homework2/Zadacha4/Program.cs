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
            Console.WriteLine("Enter 1 number: ");
            int temp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2 number: ");
            int temp2 = int.Parse(Console.ReadLine());
            if (temp1 < temp2)
            {
                for (int i = temp2; i > 0; i--)
                {
                    if ((temp1 % i == 0) && (temp2 % i == 0))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            if(temp2<temp1)
            {
                for (int i = temp1; i > 0; i--)
                {
                    if ((temp1 % i == 0) && (temp2 % i == 0))
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
