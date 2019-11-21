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
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
            SqlConnection scon = new SqlConnection(mycon);
            String myquery = "select * from Registration where email='" + txtUserName.Text + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            String uname;
            String pass;
            if (ds.Tables[0].Rows.Count > 0)
            {
                uname = ds.Tables[0].Rows[0]["email"].ToString();
                pass = ds.Tables[0].Rows[0]["password"].ToString();

                scon.Close();
                if (uname == txtUserName.Text && pass == txtPassword.Text)
                {
                    Session["username"] = uname;
                    Session["buyitems"] = null;
                    fillsavedCart();
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Label5.Text = "Invalid Username or Password - Relogin with Correct Username Password";
                }
            }
            else
            {
                Label5.Text = "Invalid Username or Password - Relogin with Correct Username Password";
            }
        }

        private void fillsavedCart()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("no");
            dt.Columns.Add("productid");
            dt.Columns.Add("productcategory");
            dt.Columns.Add("productname");
            dt.Columns.Add("productdescription");
            dt.Columns.Add("productquantity");
            dt.Columns.Add("unitprice");
            dt.Columns.Add("totalprice");
            dt.Columns.Add("imageurl");

            String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
            SqlConnection scon = new SqlConnection(mycon);
            String myquery = "select * from cartt where username='" + Session["username"].ToString() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = scon;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                int i = 0;
                int counter = ds.Tables[0].Rows.Count;
                while (i < counter)
                {
                    dr = dt.NewRow();
                    dr["no"] = i + 1;
                    dr["productid"] = ds.Tables[0].Rows[i]["productid"].ToString();
                    dr["productcategory"] = ds.Tables[0].Rows[i]["productcategory"].ToString();
                    dr["productname"] = ds.Tables[0].Rows[i]["productname"].ToString();
                    dr["productdescription"] = ds.Tables[0].Rows[i]["productdescription"].ToString();
                    dr["imageurl"] = ds.Tables[0].Rows[i]["imageurl"].ToString();
                    dr["productquantity"] = "1";
                    dr["unitprice"] = ds.Tables[0].Rows[i]["unitprice"].ToString();
                    int price1 = Convert.ToInt16(ds.Tables[0].Rows[i]["unitprice"].ToString());
                    int quantity1 = Convert.ToInt16(ds.Tables[0].Rows[i]["productquantity"].ToString());
                    int totalprice1 = price1 * quantity1;
                    dr["totalprice"] = totalprice1;
                    dt.Rows.Add(dr);
                    i = i + 1;
                }

            }
            else
            {
                Session["buyitems"] = null;
            }
            Session["buyitems"] = dt;
        }
    }
}