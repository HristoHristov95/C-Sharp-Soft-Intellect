using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            String text;
            List<String> list = new List<String>();
            text=Console.ReadLine();
            while(!text.Equals(""))
            {
                list.Add(text);
                text=Console.ReadLine();
            }
            String word;
            Console.WriteLine("Enter word: ");
            word = Console.ReadLine();
            String pattern = "[.?!]";
            for(int i=0;i<list.Count;i++)
            {
                if(list.ElementAt(i).Contains(word))
                {
                    String[] temp = Regex.Split(list.ElementAt(i), pattern,RegexOptions.IgnoreCase);
                    for (int k = 0; k < temp.Length; k++)
                    {
                        if (temp[k].Contains(word))
                        {
                            Console.Write(temp[k]);
                            Console.WriteLine("");
                        }
                    }
                }
            }
        }
    }
}
