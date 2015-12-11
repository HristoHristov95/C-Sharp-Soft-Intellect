using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Proffesor : Lecturer
    {
        String title;
        public Proffesor(String title,String univercityName,String subject, String name, int age, String staj): base(univercityName,subject,name,age,staj)
        {
            this.title = title;
        }
        public Proffesor():base()
        {

        }
        public void SayTitleAndStaj()
        {
            Console.WriteLine("The Title is : " + this.title + " and the years of #STAJ are : " + this.Staj);
        }
        public override String CheckHomework(bool a)
        {
            if (a)
            {
                return "With homework Different from Lecturer";
            }
            else
            {
                return "Without homework Different From Lecturer";
            }
        }
        public void GiveTests()
        {
            Console.WriteLine("Test ...");
        }
    }
}
