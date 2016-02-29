using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example
{
    public class Info
    {
        private String country;
        private String capital;
        private Decimal population;
        public Info(String country,String capital,Decimal population)
        {
            this.Country = country;
            this.Capital = capital;
            this.Population = population;
        }
        public String Country { get { return this.country; } set { this.country = value; } }
        public String Capital { get { return this.capital; } set { this.capital = value; } }
        public Decimal Population { get { return this.population; } set { this.population = value; } }
        public override string ToString()
        {
            return this.Country + "|" + this.Capital + "|" + this.Population;
        }
    }
}