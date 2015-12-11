using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Lecturer : Teacher
    {
        protected String univercityName;
        public const int allHoursAWekk = 10;
        public Lecturer():base()
        {

        }
        public Lecturer(String univercityName, String subject, String name, int age, String staj)
            : base(subject, name, age, staj)
        {
            this.univercityName = univercityName;
        }
        public override String CheckHomework(bool a)
        {
            if (a)
            {
                return "With homework";
            }
            else
            {
                return "Without homework";
            }
        }
        public String UnivercityName { get { return this.univercityName; } set { this.univercityName = value; } }
        public void Exercises()
        {

        }
        public void Exercises(String second)
        {

        }
        public void Exercises(String second,String third)
        {

        }
        public override void Hello()
        {
            Console.WriteLine("Holla holla get ma dolla ");
        }
        public override void Goodbye()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
