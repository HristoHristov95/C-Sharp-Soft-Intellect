using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        public static Thread th1,th2;
        public static void runHelper1()
        {
            for(int i=0;i<50000;i++)
            {
                Console.WriteLine(i);
                if(i==25000)
                {
                    th2.Join();
                }
            }
        }
        public static void runHelper2()
        {
            for(int i=0;i<20;i++)
            {
                Console.WriteLine("Running...");
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            th1 = new Thread(new ThreadStart(runHelper1));
            th2 = new Thread(new ThreadStart(runHelper2));
            th1.Start();
            th2.Start();
        }
    }
}
