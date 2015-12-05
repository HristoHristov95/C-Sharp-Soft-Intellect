using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        public static int MaxNumbers(int a,int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public static int MaxNumbers(){
            Console.WriteLine("Enter 3 numbers please !");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a < b && c < b)
            {
                return b;
            }
            if (b < a && c < a)
            {
                return a;
            }
            if (a < c && b < c)
            {
                return c;
            }
             if(true){
              throw new System.ArgumentException("Invalid !");
            }

        }
        static void Main(string[] args)
        {
            int a = 5, b = 6;
            int result1,result2;
            result1=MaxNumbers(a, b);
            result2=MaxNumbers();
            Console.WriteLine("Result 1 : " + result1);
            Console.WriteLine("Result 2 : " + result2);
    }
    }
}
