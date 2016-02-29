using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Example
{
    public static class FileManipulation
    {
        public static List<Info> readFile()
        {
            List<Info> list = new List<Info>();
            try
            {
                using (StreamReader rd = new StreamReader("C:\\Users\\Hristov\\fileSample.txt"))
                {
                    while (!rd.EndOfStream)
                    {
                        String[] temp = rd.ReadLine().Split('|');
                        Info obj = new Info(temp[0], temp[1], Decimal.Parse(temp[2]));
                        list.Add(obj);
                    }
                }
            }catch(FileNotFoundException ex)
            {
                throw ex;
            }
            return list;
        }
        public static void writeFile(List<Info> list)
        {
            using (StreamWriter wr=new StreamWriter("C:\\Users\\Hristov\\fileSample.txt", true))
            {
                for(int i=0;i<list.Count;i++)
                {
                    wr.WriteLine(list.ElementAt(i).ToString());
                }
            }
        }
    }
}