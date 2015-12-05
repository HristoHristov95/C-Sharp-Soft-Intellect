using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    public class Car
    {
        protected double price;
        public Car(double price)
        {
            this.Price = price;
        }
        public double Price { get { return this.price; } set { this.price = value; } }
        public static void Main()
        {
        }
    }
}
