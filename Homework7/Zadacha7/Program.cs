using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("text.txt");
            StreamWriter writer = new StreamWriter("Text1.txt");
            StreamWriter writer2 = new StreamWriter("Text2.txt");
            int counter = 1;
            while(!input.EndOfStream)
            {
                if(counter%2==0)
                {
                    writer.WriteLine(input.ReadLine());
                }
                if(counter%2==1)
                {
                    writer2.WriteLine(input.ReadLine());
                }
                counter++;
            }
            input.Close();
            writer.Close();
            writer2.Close();
        }
    }
}
