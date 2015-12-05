using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        private double celsius;
        private double farenheight;
        public Program(double celsius)
        {
            Celsius = celsius;
        }
        public void Convert()
        {
            Farenheight = ((this.celsius * 1.8) + 32);
        }
        public double Celsius { get { return this.celsius; } set { this.celsius = value; } }
        public double Farenheight { get { return this.farenheight; } set { this.farenheight = value; } }
        static void Main(string[] args)
        {
            Program test = new Program(20);
            test.Convert();
            Console.WriteLine("Celsius: " + test.Celsius + " Farenheight: " + test.Farenheight);
        }
    }
}
