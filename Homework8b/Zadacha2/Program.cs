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
            String text = "This is a simple text that count unique words . And this is the text that must be checked";
            HashSet<String> words = new HashSet<string>();
            String[] differentWords = text.Split(' ');
            for(int i=0;i<differentWords.Length;i++)
            {
                words.Add(differentWords[i]);
            }
            Console.WriteLine("Here are all the unique words : ");
            for(int i=0;i<words.Count;i++)
            {
                Console.WriteLine(words.ElementAt(i));
            }
        }
    }
}
