using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
          //  BigInteger a = 0;
            int[] array=new int[10];
            int count = 0;
            for(int i=1;count<10;i++)
            {
                array[count++] = i * 10;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
