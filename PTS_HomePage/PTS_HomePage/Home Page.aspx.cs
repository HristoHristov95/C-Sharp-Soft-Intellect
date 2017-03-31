using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PTS_HomePage
{
    public partial class Home_Page : System.Web.UI.Page
    {
        public static List<DataTemplate> list;
        private void BindRepeater()
        {
            PagedDataSource pgitems = new PagedDataSource();
            pgitems.DataSource = list;
            pgitems.AllowPaging = true;
            pgitems.PageSize = 4;
            pgitems.CurrentPageIndex = PageNumber;
            if (pgitems.PageCount > 1)
            {
                rptPaging.Visible = true;
                List<String> pages = new List<String>();
                for (int i = 0; i <= pgitems.PageCount - 1; i++)
                {
                    pages.Add((i + 1).ToString());
                }
                rptPaging.DataSource = pages;
                rptPaging.DataBind();
            }
            else
            {
                rptPaging.Visible = false;
            }
            repeater.DataSource = pgitems;
            repeater.DataBind();
            int count = 0;
            foreach (RepeaterItem item in repeater.Items)
            {
                Repeater rep = (Repeater)item.FindControl("insideRepeater");
                rep.DataSource = list.ElementAt(count).Path_To_Images;
                rep.DataBind();
                count++;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            /*   string isUser = Application["login_result"].ToString();
               string user_name = Application["user_naem"].ToString();
               if (isUser.Equals("true"))
               {
                   Register.Visible = false;
                   Login.Visible = false;
                   User_dropdownlist.Items[0].Text = user_name;
               }*/
        }
        protected void Register_Click(object sender, EventArgs e)
        {
            Server.Transfer("Register.aspx", true);
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login_page.aspx", true);
        }
        protected void Car_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.Car_name_list.SelectedValue)
            {
                case "Bmw":
                    var items = new List<ListItem>() { new ListItem("All models"), new ListItem("330"), new ListItem("320"), new ListItem("318"), new ListItem("420"), new ListItem("430"), new ListItem("530") };
                    this.Model_name.DataSource = items;
                    break;
                case "Audi":
                    var items1 = new List<ListItem>() { new ListItem("All models"), new ListItem("A1"), new ListItem("A2"), new ListItem("A3"), new ListItem("A4"), new ListItem("A5"), new ListItem("A6"), new ListItem("A7"), new ListItem("A8"), new ListItem("R8") };
                    this.Model_name.DataSource = items1;
                    break;
                case "Vw":
                    var items2 = new List<ListItem>() { new ListItem("All models"), new ListItem("Passat"), new ListItem("Golf"), new ListItem("CC"), new ListItem("Jetta"), new ListItem("Passat CC"), new ListItem("Sharan"), new ListItem("Touran"), new ListItem("Up") };
                    this.Model_name.DataSource = items2;
                    break;
                case "Volvo":
                    var items3 = new List<ListItem>() { new ListItem("All models"), new ListItem("142"), new ListItem("240"), new ListItem("340"), new ListItem("480"), new ListItem("66"), new ListItem("765"), new ListItem("V40") };
                    this.Model_name.DataSource = items3;
                    break;
                case "Ferrari":
                    var items4 = new List<ListItem>() { new ListItem("All models"), new ListItem("458 Italia"), new ListItem("360 spider"), new ListItem("Enzo"), new ListItem("599"), new ListItem("California"), new ListItem("FF"), new ListItem("LaFerrari") };
                    this.Model_name.DataSource = items4;
                    break;
            }
            this.Model_name.DataBind();
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            try
            {
                list = ReadDataFromFile.read_data();
                if (Car_name_list.SelectedValue.ToString().Equals("All"))
                {
                    repeater.DataSource = list;
                    repeater.DataBind();
                    repeater.Visible = true;
                }
                else
                {
                    if (Model_name.SelectedValue.ToString().Equals("All models"))
                    {
                        list = list.Where(x => x.Car_Brand.Equals(Car_name_list.SelectedValue.ToString())).ToList<DataTemplate>();
                        repeater.DataSource = list;
                        repeater.DataBind();
                        repeater.Visible = true;
                    }
                    else
                    {
                        list = list.Where(x => x.Car_Brand.Equals(Car_name_list.SelectedValue.ToString()) && x.Car_Model.Equals(Model_name.SelectedValue.ToString())).ToList<DataTemplate>();
                        repeater.DataSource = list;
                        repeater.DataBind();
                        repeater.Visible = true;
                    }
                }
            }
            catch (FileNotFoundException exe)
            {
                exception1.Text = exe.Message;
            }

            BindRepeater();
        }

        protected void User_dropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = User_dropdownlist.SelectedItem.Value.ToString();
            switch (choice)
            {
                case "Logout":
                    Application["login_result"] = "false";
                    Application["user_naem"] = "none";
                    Page_Load(sender, e);
                    break;
                case "Profile":
                    Server.Transfer("Profile_page.aspx", true);
                    break;
                default: break;
            }
        }

        protected void rptPaging_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;
            BindRepeater();
        }
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                {
                    return Convert.ToInt32(ViewState["PageNumber"]);
                }
                else
                {
                    return 0;
                }
            }
            set { ViewState["PageNumber"] = value; }
        }
    }
}