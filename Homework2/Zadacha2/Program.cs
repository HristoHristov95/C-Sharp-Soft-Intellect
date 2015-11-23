using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number between 0-9");
            try
            {
                int temp = int.Parse(Console.ReadLine());
                if(temp>=1 && temp<=9)
                {
                    if (temp >= 1 && temp <= 3)
                    {
                        temp += 5;
                    }
                    if(temp>=4 && temp<=6)
                    {
                        temp *= 12;
                    }
                    if(temp>=7 && temp<=9)
                    {
                        temp *= 50;
                        temp /= 3;
                    }
                }
                Console.WriteLine(temp);
            }
            catch(System.ArgumentNullException e){

            }
            catch (System.FormatException e)
            {

            }
            catch(Exception e)
            {
                Console.WriteLine("WTF???");
            }
        }
    }
}
