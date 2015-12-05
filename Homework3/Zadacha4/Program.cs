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
            int[] array = new int[] { 5, 2, 6, 11, 87, 33, 8, 33, 45, 234, 88, 112, 335, 788, 654 };
            Console.WriteLine("What number you want to search for ? ");
            int numberToSearch = int.Parse(Console.ReadLine());
            int index=0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] == numberToSearch)
                {
                    index = i; // tuka index ot 0-duljina ili 1-duljina ako e s 1 znachi shte e ... i+1;
                }
            }
            Console.WriteLine("Result: " + index);
        }
    }
}
