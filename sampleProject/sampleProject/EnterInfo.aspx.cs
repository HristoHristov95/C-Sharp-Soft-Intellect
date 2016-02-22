using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sampleProject
{
    public partial class EnterInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnterButton(object sender, EventArgs e)
        {
            try
            {
                DateTime date1 = DateTime.Parse(data123.Text);
                String product1 = product.Text;
                String price1 = price.Text;
                String allData = date1.ToShortDateString() + "|" + product1 + "|" + price1;
                List<String> list = new List<String>();
                list.Add(allData);
                DataManagement.enterInfo(list);
            }catch(ArgumentNullException en1)
            {
                exceptionHandling.Text = en1.Message;
            }
            catch(FormatException en1)
            {
                exceptionHandling.Text = en1.Message;
            }
        }
    }
}