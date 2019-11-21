using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab_3
{
    public partial class WebForm27 : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
        }
    }
    
}