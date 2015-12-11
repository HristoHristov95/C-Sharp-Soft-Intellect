using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Teacher : Person
    {
        protected String subject;
        public Teacher():base()
        {

        }
        public Teacher(String subject, String name, int age, String staj)
            : base(name, age, staj)
        {
            this.subject = subject;
        }
        public virtual String CheckHomework(bool a)
        {
            if(a)
            {
                return "With homework";
            }
            else
            {
                return "Without homework";
            }
        }
        public String Subject { get { return this.subject; } set { this.subject = value; } }
        public virtual void Hello()
        {
            Console.WriteLine("Hello motherfucker"); //https://www.youtube.com/watch?v=Ada6gL3uZH8
        }
        public virtual void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
