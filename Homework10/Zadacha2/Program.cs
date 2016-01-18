using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zadacha2
{
    class Program
    {
        public static void readAndCheck (String fileName)
        {
            fileName=fileName+".txt";
            using(StreamReader rf=new StreamReader(fileName))
            {
                while(!rf.EndOfStream)
                {
                    String temp = rf.ReadLine();
                    if(temp.Contains('.') || temp.Contains('?') || temp.Contains('!'))
                    {
                        continue;
                    }
                    else
                    {
                        throw new SentenceNotCompleted("The sentence was not complete !");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file to read : ");
            String filename = Console.ReadLine();
            try
            {
                readAndCheck(filename);
            }catch(SentenceNotCompleted e){
                Console.WriteLine(e.Message);
                return;
           
            }catch(IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch(Exception e)
            {
                Console.WriteLine("This is a default exception !");
                return;
            }
            Console.WriteLine("Everything was okey in the file .");
        }
    }
}
