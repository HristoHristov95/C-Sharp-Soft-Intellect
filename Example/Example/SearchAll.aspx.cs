using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example
{
    public partial class SearchAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            List<Info> list = FileManipulation.readFile();
            List<Info> temporary = new List<Info>();
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list.ElementAt(i).Country.Equals(TextBox1.Text) && list.ElementAt(i).Capital.Equals(TextBox2.Text))
                    {
                        if (list.ElementAt(i).Population >= Decimal.Parse(TextBox3.Text) && list.ElementAt(i).Population <= Decimal.Parse(TextBox4.Text))
                        {
                            temporary.Add(list.ElementAt(i));
                        }
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