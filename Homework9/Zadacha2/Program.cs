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
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(0, 100) + 1;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int temp = 0; temp < 10; temp++)
                {
                    if (array[i] < array[temp])
                    {
                        int temp1 = array[i];
                        array[i] = array[temp];
                        array[temp] = temp1;
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
