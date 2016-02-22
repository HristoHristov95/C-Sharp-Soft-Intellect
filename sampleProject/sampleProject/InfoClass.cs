using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sampleProject
{
    public class InfoClass
    {
        private String date;
        private String razhod;
        private String price;
        public InfoClass(String date,String razhod,String price)
        {
            this.Date = date;
            this.Expenses = razhod;
            this.Price = price;
        }
        public String Date { get { return this.date; } set { this.date = value; } }
        public String Expenses { get { return this.razhod; } set { this.razhod = value; } }
        public String Price { get { return this.price; } set { this.price = value; } }
    }
}