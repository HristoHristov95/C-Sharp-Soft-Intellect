using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list=new List<String>();
            String word, text;
            Console.WriteLine("Enter word first: ");
            word = Console.ReadLine();
            Console.WriteLine("Now enter text: ");
            text = Console.ReadLine();
            while(!text.Equals(""))
            {
                list.Add(text);
                text = Console.ReadLine();
            }
            for(int i=0;i<list.Count;i++)
            {
                if(list.ElementAt(i).Contains(word))
                {
                    String[] temp = list.ElementAt(i).Split(' ');
                    for(int temp1=0;temp1<temp.Length;temp1++)
                    {
                        if(temp[temp1].Equals(word))
                        {
                            Console.Write(temp[temp1].ToUpper()+" ");
                        }
                        else
                        {
                            Console.Write(temp[temp1]+" ");
                        }
                    }
                    Console.WriteLine("");
                } 
                else{
                    Console.WriteLine(list.ElementAt(i));
                }
            }
        }
    }
}
