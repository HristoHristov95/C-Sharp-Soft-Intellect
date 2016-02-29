using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example
{
    public partial class SearchPopulation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            List<Info> temporary = new List<Info>();
            try
            {
                Decimal min = Decimal.Parse(TextBox.Text);
                Decimal max = Decimal.Parse(TextBox1.Text);
                List<Info> list = FileManipulation.readFile();
                for(int i=0;i<list.Count;i++)
                {
                    if(list.ElementAt(i).Population<= max && list.ElementAt(i).Population >= min)
                    {
                        temporary.Add(list.ElementAt(i));
                    }
                }
            }
            catch (ArgumentNullException e1)
            {
                label.Text = e1.Message;
            }
            catch (FormatException e2)
            {
                label.Text = e2.Message;
            }
            catch (OverflowException e3)
            {
                label.Text = e3.Message;
            }
            Repeater.DataSource = temporary;
            Repeater.DataBind();
        }
    }
}