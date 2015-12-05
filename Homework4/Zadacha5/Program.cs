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
            int a = 11000011;
            String chislo = a.ToString();
            char[] array = chislo.ToCharArray();
            int flag = 1;
            for (int i = 0,k=array.Length-1;i<array.Length/2 ; i++,k--)
            {
                if(array[i].Equals(array[k]))
                {
                    continue;
                }
                else
                {
                    flag = 0;
                    break;
                }
            }
            if(flag != 0)
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NE");
            }
        }
    }
}
