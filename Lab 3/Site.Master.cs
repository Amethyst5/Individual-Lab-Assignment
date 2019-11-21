using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Lab_3
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            if (dt != null)
            {

                Label1.Text = dt.Rows.Count.ToString();
            }
            else
            {
                Label1.Text = "0";
            }

            if (Session["username"] == null)
            {
                Label2.Text = "Hello Guest,";
                LinkButton3.Visible = true;//view cart
                LinkButton1.Visible = false;
                //HyperLink1.Visible = false;
            }
             else
            {
                Label2.Text = "Hello " + Session["username"].ToString();
                LinkButton3.Visible = false;
                LinkButton1.Visible = true;
                //HyperLink1.Visible = true;
            }

            if (Convert.ToString(Session["username"]) == "admin")
            {
                HyperLink1.Visible = true;
            }
            else
            {
                HyperLink1.Visible = false;
            }

            // if(Session["username"] == "admin")
            //  {
            //  HyperLink1.Visible = true;
            // }
            // else
            //{
            // HyperLink1.Visible = false;
            // }


        }

        //if login  if (UserName.Text == "Admin" && Pass.Text == "123")
       // {
          //  HyperLink1.Visible = true;
       // }



    protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        //logout
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Home.aspx");

        }

       
    }
}
