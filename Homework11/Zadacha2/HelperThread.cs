using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadacha2
{
    class HelperThread
    {
        private int threadNumber;
        public HelperThread( int number)
        {
            this.threadNumber = number;
        }
        public void runHelperThread(object s)
        {
            Random rand = new Random();
            Console.WriteLine("Helper thread {0} is started !", this.threadNumber);
            Console.WriteLine("Hello my i am a helper thread and my name is : " + s);
            int time = (rand.Next(0, 10) + 1);
            time *= 1000;
            Thread.Sleep(time);
            Console.WriteLine("Thread {0} complete !", this.threadNumber);
        }
    }
}
