using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{6, 4, 3, 8, 6, 12, 13, 66};
            int sum=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("Result: " + sum);
        }
    }
}
