using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework10
{
    class Program
    {
        public static String readfile(String fileName)
        {
            String content;
             using(StreamReader rd=new StreamReader(fileName))
             {
                 content = rd.ReadToEnd();
             }
             return content;
        }
        public static void writeFile(String filename,String content)
        {
            filename = filename + ".txt";
            using(StreamWriter wr=new StreamWriter(filename))
            {
                wr.Write(content);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter filename to read : ");
            String filename=Console.ReadLine();
            try
            {
               String content=readfile(filename);
                Console.WriteLine("Enter filename to write file : ");
                String fileNameWrite=Console.ReadLine();
                writeFile(fileNameWrite, content);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ArgumentException e){
                Console.WriteLine(e.Message);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
