using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter word");
            String word = Console.ReadLine();
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            Console.Write("Here is the result:");
            for(int i=0;i<array.Length;i++)
            {
                Console.Write("{0}", array.ElementAt(i));
            }
        }
    }
}
