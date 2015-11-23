using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers are you going to enter ?");
            int ofNumbers = int.Parse(Console.ReadLine());
            int temp;
            int temp1;
            int numMax=0;
            int numMin=0;
            int flag1 = 0;
            Console.WriteLine("Now enter the numbers: ");
            temp = int.Parse(Console.ReadLine());
            temp1 = int.Parse(Console.ReadLine());
            for(int i=2;i<ofNumbers;)
            {
                if(flag1==0)
                {
                    if(temp<temp1)
                    {
                        numMin = temp;
                    }
                    else
                    {
                        numMax = temp1;
                    }
                    flag1 = 1;
                }
                if(numMin>temp)
                {
                    numMin = temp;
                }
                if(numMax<temp)
                {
                    numMax = temp;
                }
                if(numMin>temp1)
                {
                    numMin = temp1;
                }
                if(numMax<temp1)
                {
                    numMax = temp1;
                }
                temp = int.Parse(Console.ReadLine());
                ++i;
                if(i==ofNumbers)
                {
                    break;
                }
                temp1 = int.Parse(Console.ReadLine());
                ++i;
            }
            Console.WriteLine("MAX: " + numMax);
            Console.WriteLine("Min: " + numMin);
        }
    }
}
