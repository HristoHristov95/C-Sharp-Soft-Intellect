using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    class CollageTeacher : Teacher
    {
        protected String CollegeName;
        public CollageTeacher()
            : base()
        {

        }
        public CollageTeacher(String collagename,String subject, String name, int age, String staj) : base(subject,name,age,staj)
        {
            this.CollegeName = collagename;
        }
    }
}
