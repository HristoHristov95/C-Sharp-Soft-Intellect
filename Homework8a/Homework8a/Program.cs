using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8a
{
    class Program
    {
        static void Main(string[] args)
        {

          /*  Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            Console.WriteLine("Please enter numbers :");
            List<uint> list = new List<uint>();
            while(true)
            {
                try
                {
                    uint number = uint.Parse(Console.ReadLine());
                    list.Add(number);
                }
                catch (Exception e)
                {
                    break;
                }
            }
            uint result=0;
            int delitel = 0;
            for(int i=0;i<list.Count;i++)
            {
                result += list.ElementAt<uint>(i);
                delitel = i+1;
            }
            Console.WriteLine("result :"+(result/delitel));
        }
    }
}
