using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8b
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence = "This is a simple text and it counts how many words there are in here and how often they are used";
            String[] words = sentence.Split(' ');
            Dictionary<String,int> dict=new Dictionary<String,int>();
            List<String> keys=new List<String>();
            for(int i=0;i<words.Length;i++)
            {
                if(dict.ContainsKey(words[i]))
                {
                    int value;
                    if(dict.TryGetValue(words[i],out value))
                    {
                        dict.Remove(words[i]);
                        value++;
                        dict.Add(words[i], value);
                    }
                }
                else
                {
                    dict.Add(words[i], 1);
                    keys.Add(words[i]);
                }
            }
            for(int i=0;i<keys.Count;i++)
            {
                int value;
                dict.TryGetValue(keys.ElementAt(i),out value);
                Console.WriteLine(string.Format("The word is {0} .And it is seen {1} times in the sentece !", keys.ElementAt(i), value));
            }
        }
    }
}
