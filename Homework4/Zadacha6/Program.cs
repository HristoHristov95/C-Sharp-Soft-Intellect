using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        public static void recursivefunc(int n,ref int result)
        {
            result = result * n;
            if(n==1)
            {
                return;
            }
            recursivefunc((n - 1),ref result);
            return;
        }
        static void Main(string[] args)
        {
            int n = 9;
            int result = 1;
            recursivefunc(n,ref result);
            Console.WriteLine("Result: " + result);
        }
    }
}
