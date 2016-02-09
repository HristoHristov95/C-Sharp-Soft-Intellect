using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] s = new String[] { "Threading1", "Threading2", "Threading3", "Threading4", "Threading5" };
            ThreadPool.SetMaxThreads(7,7);
            for(int i=0;i<5;i++)
            {
                HelperThread th = new HelperThread(i);
                ThreadPool.QueueUserWorkItem(new WaitCallback(th.runHelperThread), s[i]);
            }
            Console.ReadLine();
        }
    }
}
