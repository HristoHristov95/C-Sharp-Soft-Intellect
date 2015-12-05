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
        public static void Multypli(int a1, int a2, int a3)
        {
            BigInteger result;
            result = a1 * a2 * a3;
            Console.WriteLine("Result: " + result);
        }
        static void Main(string[] args)
        {
            Random a=new Random();
            for (int i = 0; i < 10; i++)
            {
                int a1 = a.Next(1, 100);
                int a2=  a.Next(1,100);
                int a3 = a.Next(1, 100);
                Multypli(a1, a2, a3);
            }
        }
    }
}
