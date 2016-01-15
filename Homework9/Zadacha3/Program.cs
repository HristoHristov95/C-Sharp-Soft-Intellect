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
            String text = "this is a test string performing test ";
            String[] words = text.Split(' ');
            List<String> listWithWords = new List<String>();
            //е тва е мое творение на изкуството с 4 for цикъла 
            for(int i=0;i<words.Length-1;i++)
            {
                char[] temp = words[i].ToCharArray();
                for (int u = i + 1; u < words.Length; u++)
                {
                    char[] temp2 = words[u].ToCharArray();
                    for (int q = 0; q < temp.Length; q++)
                    {
                        for (int w = 0; w < temp2.Length; w++)
                        {
                            if (temp[q] > temp2[w])
                            {
                                char[] s =temp;
                                temp = temp2;
                                temp2 = s;
                                String t1 = new String(temp);
                                String t2 = new String(temp2);
                                words[i] = t1;
                                words[u] = t2;
                                break;
                            }
                            if(temp[q]==temp2[w])
                            {
                                continue;
                            }
                            break;
                        }
                        break;
                    }
                }
            }
            Console.WriteLine("Here is the list with sorted words :");
            Console.WriteLine();
            for(int i=0;i<words.Length;i++)
            {
                Console.WriteLine(words.ElementAt(i));
            }
            // а иначе има и много много много много ..., по лесен начин за цялата тая работа и нея съм я написал да няма сърдити после :D 
            text = "this is a test string performing test ";
            String[] wordsT2 = text.Split(' ');
            Array.Sort(wordsT2);
            Console.WriteLine("Second test for the program : ");
            Console.WriteLine();
            for(int i=0;i<wordsT2.Length;i++)
            {
                Console.WriteLine(wordsT2[i]);
            }
        }
    }
}
