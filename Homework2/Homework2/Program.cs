using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter What u want !?!");
            String temp = Console.ReadLine();
            int tempp = 0;
            double temp1 = 0;
            String temp2 = null;
            temp2 = temp;
            if (int.TryParse(temp, out tempp))
            {
                tempp = int.Parse(temp);
                tempp++;
                Console.WriteLine(tempp);
            }
            else if (double.TryParse(temp, out temp1))
            {
                temp1 = double.Parse(temp);
                temp1++;
                Console.WriteLine(temp1);
            }
            else if (temp2 != null)
            {
                temp2 = temp2 + "*";
                Console.WriteLine(temp2);
            }
        }
    }
}
