using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int count = 0,temp=0,resultNumber=0;
            array[0] = 3;
            array[1] = 6;
            array[2] = 7;
            array[3] = 6;
            array[4] = 99;
            array[5] = 6;
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = 0; k < array.Length; k++)
                {
                    if (array[i] == array[k])
                    {
                        count++;
                    }
                }
                if (temp < count)
                {
                    temp = count;
                    resultNumber = array[i];
                    count = 0;
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine("Number is : " + resultNumber);
            Console.WriteLine("Encounters : " + (temp-1));
        }
    }
}
