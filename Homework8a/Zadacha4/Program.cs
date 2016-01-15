using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> dict = new Dictionary<int, int>();
            int[] array = new int[100];
            Random rand = new Random();
            int counter = 1;
            List<int> keys = new List<int>();
            for(int i=0;i<70;i++)
            {
                array[i] = 10;
            }
            for (int i = 70; i < 100;i++)
            {
                array[i] = (rand.Next(100) + 1);
            }
                for (int i = 0; i < array.Length; i++)
                {
                    if (dict.ContainsKey(array[i]))
                    {
                        int number = 0;
                        if (dict.TryGetValue(array[i], out number))
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
            int biggest;
            int element=0;
            dict.TryGetValue(keys.ElementAt(0),out biggest);
            for(int i=0;i<keys.Count;i++)
            {
                int temp;
                dict.TryGetValue(keys.ElementAt(i),out temp);
                if(biggest<temp)
                {
                    biggest = temp;
                    element = i;
                }
            }
            if(biggest>=((array.Length/2)+1))
            {
                Console.WriteLine("The majorant is : " + keys.ElementAt(element));
            }
            else
            {
                Console.WriteLine("The majorant doesnt excist !");
            }
        }
    }
}
