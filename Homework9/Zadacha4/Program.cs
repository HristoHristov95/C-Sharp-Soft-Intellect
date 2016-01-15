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
            int counter=0;
            int counter2=0;
            int[] array = new int[1000];
            int countChetni = 0;
            int countNechetni = 0;
            Random rand = new Random();
            for(int i=0;i<1000;i++)
            {
                array[i] = (rand.Next(0, 100) + 1);
                if(array[i]%2==0)
                {
                    countChetni++;
                }
                else
                {
                    countNechetni++;
                }
            }
            int[] chetni = new int[countChetni];
            int[] nechetni = new int[countNechetni];
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i]%2==0)
                {
                    chetni[counter++] = array[i];
                }
                else
                {
                    nechetni[counter2++] = array[i];
                }
            }
            int result1 = Environment.TickCount;
            Array.Sort(chetni);
            Console.WriteLine("Timer for chetni : " + (Environment.TickCount - result1));
            int result2 = Environment.TickCount;
            Array.Sort(nechetni);
            Console.WriteLine("Time for nechetni : " + (Environment.TickCount - result2));
        }
    }
}
