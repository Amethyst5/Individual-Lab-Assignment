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
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] == null)
            {
                Response.Redirect("testlogin.aspx");
            }
            else
            {
                Label3.Text = "Hello " + Session["username"].ToString();
                LinkButton4.Visible = true;
                LinkButton5.Visible = false;

            }
            if (!IsPostBack)
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


                if (Request.QueryString["id"] != null)
                {
                    if (Session["Buyitems"] == null)
                    {

                        dr = dt.NewRow();
                        String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
                        SqlConnection scon = new SqlConnection(mycon);
                        String myquery = "select * from productdetails where productid=" + Request.QueryString["id"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dr["no"] = 1;
                        dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                        dr["productcategory"] = ds.Tables[0].Rows[0]["productcategory"].ToString();
                        dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        dr["productdescription"] = ds.Tables[0].Rows[0]["productdescription"].ToString();
                        dr["imageurl"] = ds.Tables[0].Rows[0]["imageurl"].ToString();
                        dr["productquantity"] = Request.QueryString["productquantity"];
                        dr["unitprice"] = ds.Tables[0].Rows[0]["unitprice"].ToString();
                        int price = Convert.ToInt16(ds.Tables[0].Rows[0]["unitprice"].ToString());
                        int quantity = Convert.ToInt16(Request.QueryString["productquantity"].ToString());
                        int totalprice = price * quantity;
                        dr["totalprice"] = totalprice;
                        savedcartdetail(1, ds.Tables[0].Rows[0]["productid"].ToString(), ds.Tables[0].Rows[0]["productcategory"].ToString(), ds.Tables[0].Rows[0]["productname"].ToString(), ds.Tables[0].Rows[0]["productdescription"].ToString(), ds.Tables[0].Rows[0]["imageurl"].ToString(), "1", ds.Tables[0].Rows[0]["unitprice"].ToString(), totalprice.ToString());
                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("testcart.aspx");

                    }
                    else
                    {

                        dt = (DataTable)Session["buyitems"];
                        int sr;
                        sr = dt.Rows.Count;

                        dr = dt.NewRow();
                        String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
                        SqlConnection scon = new SqlConnection(mycon);
                        String myquery = "select * from productdetails where productid=" + Request.QueryString["id"];
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = scon;
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        dr["sno"] = sr + 1;
                        dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                        dr["productcategory"] = ds.Tables[0].Rows[0]["productcategory"].ToString();
                        dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        dr["productdescription"] = ds.Tables[0].Rows[0]["productdescription"].ToString();
                        dr["imageurl"] = ds.Tables[0].Rows[0]["imageurl"].ToString();
                        dr["productquantity"] = Request.QueryString["productquantity"];
                        dr["unitprice"] = ds.Tables[0].Rows[0]["unitprice"].ToString();
                        int price = Convert.ToInt16(ds.Tables[0].Rows[0]["unitprice"].ToString());
                        int quantity = Convert.ToInt16(Request.QueryString["productquantity"].ToString());
                        int totalprice = price * quantity;
                        dr["totalprice"] = totalprice;
                        savedcartdetail(sr + 1, ds.Tables[0].Rows[0]["productid"].ToString(), ds.Tables[0].Rows[0]["productcategory"].ToString(), ds.Tables[0].Rows[0]["productname"].ToString(), ds.Tables[0].Rows[0]["productdescription"].ToString(), ds.Tables[0].Rows[0]["imageurl"].ToString(), "1", ds.Tables[0].Rows[0]["unitprice"].ToString(), totalprice.ToString());
                        dt.Rows.Add(dr);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();

                        Session["buyitems"] = dt;
                        GridView1.FooterRow.Cells[5].Text = "Total Amount";
                        GridView1.FooterRow.Cells[6].Text = grandtotal().ToString();
                        Response.Redirect("testcart.aspx");

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
                //Label2.Text = GridView1.Rows.Count.ToString();

            }


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

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                int sr;
                int sr1;
                string qdata;
                string dtdata;
                sr = Convert.ToInt32(dt.Rows[i]["no"].ToString());
                TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
                qdata = cell.Text;
                dtdata = sr.ToString();
                sr1 = Convert.ToInt32(qdata);

                if (sr == sr1)
                {
                    dt.Rows[i].Delete();
                    dt.AcceptChanges();
                    //Label1.Text = "Item Has Been Deleted From Shopping Cart";
                    break;

                }
            }

            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                dt.Rows[i - 1]["no"] = i;
                dt.AcceptChanges();
            }

            Session["buyitems"] = dt;
            Response.Redirect("testcart.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["buyitems"] = null;
            clearsavedcart();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["buyitems"] = null;
            clearsavedcart();
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("testlogin.aspx");

        }

        private void clearsavedcart()
        {
            String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";

            String updatedata = "delete from cartt where username='" + Session["username"].ToString() + "'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Response.Redirect("testcart.aspx");
        }
        private void savedcartdetail(int no, String productid, String productcategory, String Productname, String productdescription, String productimage, String productquantity, String unitprice, String totalprice)
        {
            String query = "insert into cartt(no,productid,productcategory,productname,productdescription,productimage,productquantity,price,totalprice,username) values(" + no + ",'" + productid + "','"+ productcategory +"','"+ Productname + "','" + productdescription + "','"+ productimage + "','" + productquantity + "','" + unitprice + "','" + totalprice + "','" + Session["username"].ToString() + "')";
            String mycon = "Data Source=LAPTOP-O9L1A028\\JHEANELL;Initial Catalog=Lab3;Integrated Security=True";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }

    }
}
