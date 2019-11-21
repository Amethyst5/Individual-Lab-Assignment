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
    public partial class WebForm25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                dt.Columns.Add("no");
                dt.Columns.Add("productid");
                dt.Columns.Add("productcategory");
                dt.Columns.Add("productname");
                dt.Columns.Add("productdescription");
                dt.Columns.Add("unitprice");
                dt.Columns.Add("productquantity");
                dt.Columns.Add("imageurl");
                dt.Columns.Add("totalprice");


                if (Request.QueryString["id"] != null)
                {
                    if (Session["Buyitems"] == null)
                    {

                        dr = dt.NewRow();
                        // String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
                        SqlConnection scon = new SqlConnection();
                        scon.ConnectionString = ConfigurationManager.ConnectionStrings["Lab3ConnectionString"].ConnectionString;
                        scon.Open();

                        String myquery = "select * from productdetails where productid=" + Request.QueryString["id"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        //mycon.open();
                        da.Fill(ds);

                        dr["no"] = 1;
                        dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                        dr["productcategory"] = ds.Tables[0].Rows[0]["productcategory"].ToString();
                        dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        dr["productdescription"] = ds.Tables[0].Rows[0]["productdescription"].ToString();
                        dr["unitprice"] = ds.Tables[0].Rows[0]["unitprice"].ToString();
                        dr["productquantity"] = Request.QueryString["productquantity"];
                        dr["imageurl"] = ds.Tables[0].Rows[0]["imageurl"].ToString();
                        int unitprice = Convert.ToInt16(ds.Tables[0].Rows[0]["unitprice"].ToString());
                        int productquantity = Convert.ToInt16(Request.QueryString["productquantity"]);
                        int totalprice = unitprice * productquantity;
                        dr["totalprice"] = totalprice;
                        //savedcartdetail(1, ds.Tables[0].Rows[0]["productid"].ToString(), ds.Tables[0].Rows[0]["productcategory"].ToString(), ds.Tables[0].Rows[0]["productname"].ToString(), ds.Tables[0].Rows[0]["productdescription"].ToString(), ds.Tables[0].Rows[0]["unitprice"].ToString(), "1", ds.Tables[0].Rows[0]["imageurl"].ToString(), totalprice.ToString());
                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[5].Text = "Total Amount ";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("Cart.aspx");

                    }
                    else
                    {

                        dt = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        //String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
                        SqlConnection scon = new SqlConnection();
                        scon.ConnectionString = ConfigurationManager.ConnectionStrings["Lab3ConnectionString"].ConnectionString;
                        scon.Open();

                        String myquery = "select * from productdetails where productid=" + Request.QueryString["id"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        dr["no"] = sr + 1;
                        dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                        dr["productcategory"] = ds.Tables[0].Rows[0]["productcategory"].ToString();
                        dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        dr["productdescription"] = ds.Tables[0].Rows[0]["productdescription"].ToString();
                        dr["unitprice"] = ds.Tables[0].Rows[0]["unitprice"].ToString();
                        dr["productquantity"] = Request.QueryString["productquantity"];
                        dr["imageurl"] = ds.Tables[0].Rows[0]["imageurl"].ToString();
                        int unitprice = Convert.ToInt16(ds.Tables[0].Rows[0]["unitprice"].ToString());
                        int productquantity = Convert.ToInt16(Request.QueryString["productquantity"]);
                        //int productquantity = Convert.ToInt16(Request.QueryString["productquantity"].ToString());
                        int totalprice = unitprice * productquantity;
                        dr["totalprice"] = totalprice;
                        //savedcartdetail(sr + 1, ds.Tables[0].Rows[0]["productid"].ToString(), ds.Tables[0].Rows[0]["productcategory"].ToString(), ds.Tables[0].Rows[0]["productname"].ToString(), ds.Tables[0].Rows[0]["productdescription"].ToString(), ds.Tables[0].Rows[0]["unitprice"].ToString(), "1", ds.Tables[0].Rows[0]["imageurl"].ToString(), totalprice.ToString());
                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("Cart.aspx");

                    }
                }
                else
                {
                    dt = (DataTable)Session["buyitems"];
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    if (GridView1.Rows.Count > 0)
                    {
                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();

                    }


                }
                // Label2.Text = GridView1.Rows.Count.ToString();

            }
            Label4.Text = DateTime.Now.ToShortDateString();
            findorderid();

        }
        public int grandtotal()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            int nrow = dt.Rows.Count;
            int i = 0;
            int gtotal = 0;
            while (i < nrow)
            {
                gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

                i = i + 1;
            }
            return gtotal;
        }
        public void findorderid()
        {
            String pass = "abcdefghijklmnopqrstuvwxyz123456789";
            Random r = new Random();
            char[] mypass = new char[5];
            for (int i = 0; i < 5; i++)
            {
                mypass[i] = pass[(int)(35 * r.NextDouble())];

            }
            String orderid;
            orderid = "Order" + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + new string(mypass);

            Label3.Text = orderid;

            Label5.Text = DateTime.Now.ToString("T");
        }
        public void saveaddress()
        {
            String updatepass = "insert into orderaddress(orderid,address,mobilenumber) values('" + Label3.Text + "','" + TextBox1.Text + "','" + TextBox2.Text + "')";
            String mycon1 = "Data Source=LAPTOP-O9L1A028\\Jheanell;Initial Catalog=Lab3;Integrated Security=True";
            SqlConnection s = new SqlConnection(mycon1);
            s.Open();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandText = updatepass;
            cmd1.Connection = s;
            cmd1.ExecuteNonQuery();
            s.Close();
        }

        //place order
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataTable dt;
            dt = (DataTable)Session["buyitems"];



            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                String updatepass = "insert into [order](no,productid,productcategory,productname,productdescription,unitprice,productquantity,imageurl,totalprice,username,orderid,date,time) values(" + dt.Rows[i]["no"] + ",'" + dt.Rows[i]["productid"] + "','" + dt.Rows[i]["productcategory"] + "','" + dt.Rows[i]["productname"] + "','" + dt.Rows[i]["productdescription"] + "','" + dt.Rows[i]["unitprice"]  +"','" + dt.Rows[i]["productquantity"] + "','" + dt.Rows[i]["imageurl"] +"','" + dt.Rows[i]["totalprice"] +"','" + Session["username"].ToString() + "','" + Label3.Text +"','" + Label4.Text +"','" + Label5.Text + "')";
                String mycon1 = "Data Source=LAPTOP-O9L1A028\\Jheanell;Initial Catalog=Lab3;Integrated Security=True";
                SqlConnection s = new SqlConnection(mycon1);
                s.Open();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = updatepass;
                cmd1.Connection = s;
                cmd1.ExecuteNonQuery();
                s.Close();

            }
            saveaddress();
            //Response.Redirect("SuccessFullOrder.aspx");
            
            Response.Redirect("SuccessOrder.aspx");
           // clearsavedcart();
        }

        private void clearsavedcart()
        {
            String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";

            String updatedata = "delete from cart where username='" + Session["username"].ToString() + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //Response.Redirect("Cart.aspx");
        }
    }
}