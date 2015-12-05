using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        public static void recursFunct(String begining,String ending)
        {
            if(ending.Length<=1)
            {
                Console.WriteLine(begining + ending);
            }
            else
            {
                for(int i=0;i<ending.Length;i++)
                {
                    String newString = ending.Substring(0, i) + ending.Substring(i + 1);
                    recursFunct(begining + ending.ElementAt(i), newString);
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number N for permutations : ");
            int N = int.Parse(Console.ReadLine());
            char[] array = new char[N];
            int allPosiblePermutations = 1;
            String temp = "";
            for(int i=0,m=1;i<N;i++,m++)
            {
                temp = temp + m;
                allPosiblePermutations *= m;
            }
            Console.WriteLine("Number of all permutations : " + allPosiblePermutations);
            recursFunct("",temp);
        }
    }
}
