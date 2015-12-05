using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            // NOTE: Тая програма съм я написал само със дебъгване като цяло, проблема е че работи на магия виж й логиката + (коментар - доста си поиграх :D )
            int N = 0,a=0,constant=0;
            int n=0,m=0,counter=1,tempCount=0; 
            Console.WriteLine("Enter the size of matrix : ");
            N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            String tracker = "right";
            String s1 = "right";
            String s2 = "left";
            String s3 = "up";
            String s4 = "down";
            for (int i = 0; i <=(N+constant); i++)
            {
                for(int k=a;k<N;k++)
                {
                    switch(tracker){
                        case "right": matrix[m, n++] = counter++;break;
                        case "left": matrix[m, n--] = counter++; break;
                        case "down": matrix[m++, n] = counter++; break;
                        case "up": matrix[m--, n] = counter++; break;
                    }
                }
                if(tempCount%2==0)
                {
                     a++;
                }
                if(tempCount%2==0)
                {
                    constant++;
                }
                switch(tracker){
                    case "right": tracker = s4; n--; m++; break;
                    case "left": tracker = s3; n++; m--;  break;
                    case "down": tracker = s2; m--; n--; break;
                    case "up": tracker = s1; m++; n++; break;
                }
                tempCount++;
            }
            for(int i=0;i<N;i++)
            {
               for(int k=0;k<N;k++)
               {
                   Console.Write(matrix[i, k] + " ");
               }
               Console.WriteLine();
            }
        }
    }
}
