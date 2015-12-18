using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count1 = 1;
            Dictionary<String,int> dict=new Dictionary<String,int>();
            Console.WriteLine("Please enter equation : ");
            String equation = Console.ReadLine();
            char[] array = equation.ToCharArray();
            dict.Add(")", 0);
            dict.Add("(", 0);
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]=='(')
                {
                    dict[")"] += count1;
                }
                if(array[i]==')')
                {
                    dict["("] += count1;
                }
            }
            int value1, value2;
            dict.TryGetValue("(", out value1);
            dict.TryGetValue(")", out value2);
            if(value1==value2)
            {
                Console.WriteLine("Correct brackets");
            }
            else
            {
                Console.WriteLine("Incorrect brackets");
            }

        }
    }
}
