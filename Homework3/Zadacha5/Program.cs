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
            Console.WriteLine("Enter array size : ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array1 = new int[arraySize];
            int[] array2 = new int[arraySize];
            Console.WriteLine("Enter first array: ");
            for (int i = 0; i < arraySize; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second array: ");
            for (int i = 0; i < arraySize; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            if (Enumerable.SequenceEqual(array1,array2))
            {
                Console.WriteLine("They ARE equal !");
            }
            else
            {
                Console.WriteLine("They ARE NOT equal !");
            }
        }
    }
}
