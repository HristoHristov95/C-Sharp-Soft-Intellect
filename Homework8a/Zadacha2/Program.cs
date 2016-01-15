using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void delete(List<int> list,int counter,int number)
        {
            if ((counter % 2) == 1)
            {
                for (int temp = 0; temp < list.Count; temp++)
                {
                    if (number == list.ElementAt<int>(temp))
                    {
                        list.RemoveAt(temp);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int counter = 0;
            list.Add(5);
            list.Add(1);
            list.Add(12);
            list.Add(15);
            list.Add(5);
            list.Add(1);
            for(int i=0;i<list.Count;i++)
            {
                int number = list.ElementAt<int>(i);
                for(int temp=0;temp<list.Count;temp++)
                {
                    if(number==list.ElementAt<int>(temp))
                    {
                        counter++;
                    }
                }
                Program.delete(list, counter, number);
                counter = 0;
            }
            if((list.Count%2)==1)
            {
                list.RemoveAt((list.Count / 2));
            }
            Console.WriteLine("Here are the numbers that are left : ");
            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }
        }
    }
}
