using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            String text;
            List<String> list = new List<String>();
            Console.WriteLine("Enter text : ");
            text = Console.ReadLine();
            while(!text.Equals(""))
            {
                list.Add(text);
                text = Console.ReadLine();
            }
            Console.WriteLine("Enter word: ");
            String word = Console.ReadLine();
            int count = 0;
            // #Тая задача е много подвеждаща като цяло има няколко решения аз така го виждам , това е 1-вото 
            //Проблема тук е че например Example: Напиша { Peoplesdf People } , като текст и дам думата :{ People } -> ще преброя count=2 което фактически е 
            //правилно защото думата Peoplesdf съдържа символите на People 
            //в себе си 
            for(int i=0;i<list.Count;i++)
            {
                if(list.ElementAt(i).Contains(word))
                {
                    int number=(list.ElementAt(i).IndexOf(word)+1);
                    String temp = list.ElementAt(i).Substring(number);
                    count++;
                    while(temp.Contains(word))
                    {
                        number = (temp.IndexOf(word)+1);
                        temp =""+ temp.Substring(number);
                        count++;
                    }
                }
            }
            Console.WriteLine("Result: " + count);
            //#А това е второто. Тука съм използвал Regex от класа Regex's и така постигам по голяма прецизност на думите ето какво имам предвид
            //Example: { Peoplesdsdg, gsds .People } -> и дам дума { People } тогава count= 1
            // Плюс това тука могат да се добавят без брои много символи за сплитване ,бързо лесно вкусно 
            String pattern = "[.!,? ]";
            int count2 = 0;
            for(int i=0;i<list.Count;i++)
            {
                String[] temp = Regex.Split(list.ElementAt(i), pattern,RegexOptions.IgnoreCase);
                for(int temp1=0;temp1<temp.Length;temp1++)
                {
                    if (temp[temp1].Equals(word))
                    {
                        count2++;
                    }
                }
            }
            Console.WriteLine("Result 2 : " + count2);
        }
    }
}
