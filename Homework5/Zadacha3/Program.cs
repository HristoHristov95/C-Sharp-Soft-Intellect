using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        private int a;
        private int b;
        public Program(int a, int b)
        {
            this.A = a;
            this.B = b;
        }
        public int A { get { return this.a; } set { this.a = value; } }
        public int B { get { return this.b; } set { this.b = value; } }
        public double Hipotenuza()
        {
            return Math.Sqrt(((this.a * this.a) + (this.b * this.b)));
        }
        public void Ugul(ref double A, ref double B, ref double C)
        {
            A =(Math.Asin((this.a / Hipotenuza())))*180/3.14; // tuka gi prevrushta ot radiani v gradusi po taq formula ama priblizitelno sus 0,05 razlika zarad double 4e ne go zima 1 a 0,98......
            B = (Math.Asin((this.b / Hipotenuza()))) * 180 / 3.14;
            C = 90;
        }
        static void Main(string[] args)
        {
            Program a1 = new Program(4, 3);
            double ugulA=0,ugulB=0,ugulC=0;
            double Hipotenuzata = a1.Hipotenuza();
            Console.WriteLine("Hip : " + a1.Hipotenuza());
            a1.Ugul(ref ugulA,ref ugulB,ref ugulC);
            Console.WriteLine("A= " + ugulA + " B= " + ugulB + " C= " + ugulC);
        }
    }
}
