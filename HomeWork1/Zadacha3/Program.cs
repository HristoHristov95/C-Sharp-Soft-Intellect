using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInfro;
            String checker = "Hello World";
            Console.WriteLine("Please enter 1 string: ");
            userInfro = Console.ReadLine();
            // #1
            if (userInfro.Equals(checker))
            {
                Console.WriteLine("The result is true");
            }
            else
            {
                Console.WriteLine("The result is not true");
            }
            // #2
            if (userInfro == checker)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
