using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumZadacha2
{
    public class Automobile : Zadacha2.Car //public class trqa go ima zaradi Zadacha2Main- Program -MAIN - inaccesable due to its protection LVL 
        //po Default sa private !!!
    {
        protected double razhodGorivo;
        public Automobile(double razhodGorivo,double price) :base(price)
        {
            Razhod = razhodGorivo;
        }
        public double Razhod { get { return this.razhodGorivo; } set { this.razhodGorivo = value; } }
        public override string ToString()
        {
            return ("Automobile -  Price is : " + Price + " Razhod: " + Razhod);
        }
        public new static void Main() // trqbva da ima new sled public shoto dava nqkav error kat startiram programata za inheritance neshto si tam beshe ako se mahne tuka tva new moje da se vidi errora :D
        {
        }
    }
}
