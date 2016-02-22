using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sampleProject
{
    public partial class CalculateInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                List<String> list = DataManagement.readInfo();
                List<InfoClass> list1 = new List<InfoClass>();
                for (int i = 0; i < list.Count; i++)
                {
                    String[] temp = list.ElementAt(i).Split('|');
                    InfoClass temp1 = new InfoClass(temp[0], temp[1], temp[2]);
                    list1.Add(temp1);
                }
                repeater.DataSource = list1;
                repeater.DataBind();
            }catch(FileNotFoundException exe)
            {
                exception1.Text = exe.Message;
            }
        }

        protected void onSelected(object sender, EventArgs e)
        {
            double result=0;
            try
            {
                if (dropdown.SelectedValue.Equals("1"))
                {
                    result = Calculations.weekly();
                }
                if (dropdown.SelectedValue.Equals("2"))
                {
                    result = Calculations.monthly();
                }
                if (dropdown.SelectedValue.Equals("3"))
                {
                    result = Calculations.yearly();
                }
            }catch(FileNotFoundException ex)
            {
                exception1.Text = ex.Message;
            }
            res.Text = result.ToString();
        }
    }
}