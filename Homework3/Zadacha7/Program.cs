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
            int N = 0;
            Console.WriteLine("Enter number for the matrix: ");
            N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            int counter=1;
            for (int i = 0; i < N; i++)
            {
                for (int m = 0; m < N; m++)
                {
                    matrix[m, i] = counter++;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int k = 0; k < N; k++)
                {
                    Console.Write(matrix[i, k]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
