using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter array size: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                if (i <= 1)
                {
                    array[i] = 1;
                }
                else
                {
                    array[i] = array[i - 1] + array[i -2];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Number " + i + ": " + array[i]);
            }
        }
    }
}
