using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,K;
            UInt64 temp1=1;
            UInt64 temp2=1;
            Console.WriteLine("Enter N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            K = int.Parse(Console.ReadLine());
            if(1<K && K<N)
            {
                for(int i=1;i<=N;i++)
                {
                    if(i==1 && temp1==1)
                    {
                        i++;
                    }
                    temp1 *=(UInt64) i;
                }
                for(int i=1;i<=K;i++)
                {
                    if(i==1 && temp2==1)
                    {
                        i++;
                    }
                    temp2 *= (UInt64)i;
                }
                Console.WriteLine("Result: " + (temp1 / temp2));
            }
        }
    }
}
