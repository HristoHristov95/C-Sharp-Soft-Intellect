using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class SchoolTeacher : Teacher
    {
        protected List<String> allClasses;
        public SchoolTeacher() : base()
        {

        }
        public SchoolTeacher(List<String> a, String subject, String name, int age, String staj)
            : base(subject, name, age, staj)
        {
            this.allClasses = a;
        }
        public void SayAllClasses()
        {
            foreach (var item in this.allClasses)
            {
                Console.WriteLine("Result: " + item);
            }
        }
        public void EntertainChildren()
        {
            Console.WriteLine("Entertain ...");
        }
    }
}
