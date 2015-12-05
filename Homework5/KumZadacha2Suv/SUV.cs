using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KumZadacha2Suv
{
    public class SUV : Zadacha2.Car
    {
        protected Boolean visokoProohodim;
        public SUV(Boolean visokoProhodim,double price) : base(price)
        {
            VisokoProhodim = visokoProhodim;
        }
        public Boolean VisokoProhodim { get { return this.visokoProohodim; } set { this.visokoProohodim = value; } }
        public override string ToString()
        {
            return ("SUV -  Price is :" + Price + " Visoko Prohodim: " + VisokoProhodim);
        }
        public new static void Main()
        {
        }
    }
}
