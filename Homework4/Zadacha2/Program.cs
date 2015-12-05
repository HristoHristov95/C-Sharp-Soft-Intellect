using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        public static void sayName(String name1)
        {
            Console.WriteLine("Hello " + name1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 name : ");
            String enterName = Console.ReadLine();
            sayName(enterName);
        }
    }
}
