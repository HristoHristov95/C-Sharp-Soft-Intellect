using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example
{
    public partial class AddInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            bool checker = false;
            bool catchChecker = false;
            String country = textbox1.Text;
            String capital = textbox2.Text;
            Decimal population = 0;
            List<Info> temporary = null;
            try
            {
                population = Decimal.Parse(textbox3.Text);
                temporary = FileManipulation.readFile();
            }
            catch (ArgumentNullException e1)
            {
                label.Text = e1.Message;
                catchChecker = true;
            }
            catch (FormatException e2)
            {
                label.Text = e2.Message;
                catchChecker = true;
            }
            catch (OverflowException e3)
            {
                label.Text = e3.Message;
                catchChecker = true;
            }
            catch (FileNotFoundException ex)
            {
                label.Text = ex.Message;
            }
            if (catchChecker == false)
            {
                if (temporary != null)
                {
                    for (int i = 0; i < temporary.Count; i++)
                    {
                        if (temporary.ElementAt(i).Country.Equals(country))
                        {
                            checker = true;
                        }
                    }
                }
                if (checker == true)
                {
                    label.Text = "Error country already excists !";
                }
                else
                {
                    Info element = new Info(country.ToLower(), capital.ToLower(), population);
                    List<Info> list = new List<Info>();
                    list.Add(element);
                    FileManipulation.writeFile(list);
                }
            }
        }
    }
}