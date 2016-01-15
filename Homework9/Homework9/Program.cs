using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array=new int[]{5,9,12,2,6,8,12,45,24,7};
            int max = 45;
            int min = 2;
            List<int>[] bucket = new List<int>[max-min+1];
            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }
            for(int i=0;i<array.Length;i++)
            {
                bucket[array[i] - min].Add(array[i]);
            }
            int temp = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        array[temp++] = bucket[i][j];
                    }
                }
            }
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
