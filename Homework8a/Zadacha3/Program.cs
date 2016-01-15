using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> keys = new List<int>();
            int[] array = new int[1000];
            Random rand = new Random();
            int counter = 1;
            for(int i=0;i<1000;i++)
            {
                array[i] = (rand.Next(100)+1);
            }
            for(int i=0;i<array.Length;i++)
            {
                if(dict.ContainsKey(array[i]))
                {
                    int number=0;
                    if(dict.TryGetValue(array[i],out number))
                    {
                        number++;
                        dict.Remove(array[i]);
                        dict.Add(array[i], number);
                    }
                }
                else
                {
                    dict.Add(array[i], counter);
                    keys.Add(array[i]);
                }
            }
            for(int i=0;i<keys.Count;i++)
            {
                int temp=0;
                dict.TryGetValue(keys.ElementAt(i),out temp);
                Console.WriteLine(string.Format("The number is : {0} .And it is contained {1} times in the array !",keys.ElementAt(i),temp));
            }
        }
    }
}
