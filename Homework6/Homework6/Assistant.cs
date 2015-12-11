using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class Assistant : Lecturer
    {
        protected bool headOfAssistanceOrNOT;
        public Assistant(): base()
        {

        }
        public Assistant(bool headOfAssistanceOrNot,String univercityName, String subject, String name, int age, String staj):base(univercityName,subject,name,age,staj)
        {
            this.headOfAssistanceOrNOT = headOfAssistanceOrNot;
        }
        public void SayHeadOfAssistanceOrNOT()
        {
            if(this.headOfAssistanceOrNOT)
            {
                Console.WriteLine("He is head of Assistance");
            }
            else
            {
                Console.WriteLine("He is NOT head of Assistance");
            }
        }
        public void WriteStatii()
        {
            Console.WriteLine("Writing ... ");
        }
        public override String CheckHomework(bool a)
        {
            if (a)
            {
                return "With homework but different";
            }
            else
            {
                return "Without homewor but different";
            }
        }
        public void CheckingAnswersOfTest()
        {
            Console.WriteLine("Checking....");
        }
    }
}
