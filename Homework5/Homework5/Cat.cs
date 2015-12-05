using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Cat
    {
        private String name;
        private int years;
        private Cat[] allCats;
        public static int countForCats;
        public void Say()
        {
            for(int i=0;i<10;i++)
            {
               Console.WriteLine("The name is : " + this.allCats[i].Name);
               Console.WriteLine("The years are : " + this.allCats[i].Years);
            }
        }
        public int Years { get { return this.years; } set { this.years = value; } } // propertyto mu e "public int Years" e toq "int" i v set-a- tipa na value=propertyto; 
        public String Name { get { return this.name; } set { this.name = value; } }
        public Cat()
        {
            this.name = "NA";
            this.years = 0;
        }
        public Cat(String name,int years)
        {
            this.Years= years; // E tva e nai golemiq konstruktor v istoriqta na C# :D Note: vij logikata 
            this.Name = name;
        }
        public void CreateCats()
        {
            this.allCats = new Cat[10];
        }
        public void AddCat(Cat a)
        {
            this.allCats[Cat.countForCats++] = a;
        }
        static void Main(string[] args)
        {
            Cat a1 = new Cat();
            String[] names=new String[]{"Samathna","John","Hitler","FatBertha","DrHouse","Ainstein","Koftor","Batman","Popei","Tom"};
            Random rand = new Random();
            a1.CreateCats();
            for(int i=0;i<10;i++)
            {
                Cat temp=new Cat(names[i],(rand.Next(15)+1));
                a1.AddCat(temp);
            }
            a1.Say();
        } 
    }
}
