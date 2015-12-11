using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    abstract class Person
    {
        protected String name;
        protected int age;
        protected String staj;
        private static int counter = 0;
        public Person ()
        {
            this.name = "Unknown";
            this.age = 0;
            this.Staj = "0";
            Person.counter++;
        }
        public Person(String name,int age,String staj)
        {
            this.name = name;
            this.age = age;
            if (int.Parse(staj) < 0)
            {
                this.staj = "Invalid value !";
            }
            else
            {
                this.staj = staj;
            }
            Person.counter++;
        }
        public String Name { get { return this.name; } set { this.name = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public String Staj { 
            get { 
                return this.staj; 
            } 
            set{
                if (int.Parse(value) < 0)
                {
                    Console.WriteLine("Invalid VALUE !!!!");
                }
                else
                {
                    this.staj = value;
                }
            } 
        }
    }
}
