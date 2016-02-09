using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace Homework13
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register(object sender, EventArgs e)
        {
            String username = txtBox.Text;
            String password="";
            if(Password.Text.Equals(RepeatedPassword.Text))
            {
                password = Password.Text;
            }
            else
            {
                Response.Redirect("WebForm2.aspx");
            }
            int age = int.Parse(Age.Text);
            String email = Email.Text;
            using (StreamWriter wr = new StreamWriter("InfoFile.txt", true))
            {
                wr.WriteLine(username);
                wr.WriteLine(password);
                wr.WriteLine(age);
                wr.WriteLine(email);
            }
        }
    }
}