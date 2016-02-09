using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework11
{
    class HelperThread
    {
        private String threadName;
        private int threadNumber;
        public HelperThread(String threadName,int number)
        {
            this.threadName = threadName;
            this.threadNumber = number;
        }
        public void runHelperThread()
        {
            Random rand=new Random();
            Console.WriteLine("Helper thread {0} is started !", this.threadNumber);
            Console.WriteLine("Hello my i am a helper thread and my name is : " + this.threadName);
            int time=(rand.Next(0,10)+1);
            time*=1000;
            Thread.Sleep(time);
            Console.WriteLine("Thread {0} complete !",this.threadNumber);
        }
    }
}
