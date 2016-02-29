using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example
{
    public partial class SearchCountry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            List<Info> list = FileManipulation.readFile();
            List<Info> temp = new List<Info>();
            for(int i=0;i<list.Count;i++)
            {
                if(TextBox.Text.Equals(list.ElementAt(i).Country))
                {
                    temp.Add(list.ElementAt(i));
                }
            }
            Repeater.DataSource = temp;
            Repeater.DataBind();
        }
    }
}