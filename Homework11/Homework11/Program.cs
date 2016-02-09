using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework11
{
    class Program
    {
        static void Main(string[] args)
        {
            HelperThread helper = new HelperThread("threding111", 1);
            HelperThread helper1 = new HelperThread("threding222", 2);
            HelperThread helper2 = new HelperThread("threding333", 3);
            HelperThread helper3 = new HelperThread("threding444", 4);
            HelperThread helper4 = new HelperThread("threding555", 5);
            Thread th = new Thread(new ThreadStart(helper.runHelperThread));
            Thread th1 = new Thread(new ThreadStart(helper1.runHelperThread));
            Thread th2 = new Thread(new ThreadStart(helper2.runHelperThread));
            Thread th3 = new Thread(new ThreadStart(helper3.runHelperThread));
            Thread th4 = new Thread(new ThreadStart(helper4.runHelperThread));
            th.Start();
            th1.Start();
            th2.Start();
            th3.Start();
            th4.Start();
        }
    }
}
