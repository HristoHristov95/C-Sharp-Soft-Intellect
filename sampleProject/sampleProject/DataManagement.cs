using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace sampleProject
{
    public static class DataManagement
    {
        public static void enterInfo(List<String> l)
        {
            using (StreamWriter wr=new StreamWriter("C:\\Users\\Hristov\\data.txt", true))
            {
                for(int i=0;i<l.Count;i++)
                {
                    wr.WriteLine(l.ElementAt(i));
                }
            }
        }
        public static List<String> readInfo()
        {
            List<String> list = new List<String>();
            try
            {
                using (StreamReader rd = new StreamReader("C:\\Users\\Hristov\\data.txt"))
                {
                    while (!rd.EndOfStream)
                    {
                        String temp = rd.ReadLine();
                        list.Add(temp);
                    }
                }
            }catch(FileNotFoundException ex)
            {
                throw;
            }
            return list;
        }
    }
}