using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        public static void getNumber(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("Числото "+ number + " Четно");
            }
            else
            {
                Console.WriteLine("Числото " + number + " Нечетно");
            }
        }
        static void Main(string[] args)
        {
            int number=5;
            int number2 = 6;
            getNumber(number);
            getNumber(number2);
        }
    }
}
