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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                //Label2.Text = "Hello " + Session["username"].ToString();
                //LinkButton2.Visible = true;
                //LinkButton3.Visible = false;

            }
            if (!IsPostBack)
            {
                DataTable dt = new DataTable();
                DataRow dr;
                //dt.Columns.Add("sno");
                //dt.Columns.Add("productid");
                //dt.Columns.Add("productname");
                //dt.Columns.Add("quantity");
                //dt.Columns.Add("price");
                //dt.Columns.Add("totalprice");
                //dt.Columns.Add("productimage");
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
                        //dr["sno"] = 1;
                        //dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                        //dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        //dr["productimage"] = ds.Tables[0].Rows[0]["productimage"].ToString();
                        //dr["quantity"] = Request.QueryString["quantity"];
                        //dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                        //int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                        //int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                        //int totalprice = price * quantity;
                        //dr["totalprice"] = totalprice;

                        dr["no"]= 1;
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
                        savedcartdetail(1, ds.Tables[0].Rows[0]["productid"].ToString(), ds.Tables[0].Rows[0]["productcategory"].ToString(), ds.Tables[0].Rows[0]["productname"].ToString(), ds.Tables[0].Rows[0]["productdescription"].ToString(), ds.Tables[0].Rows[0]["unitprice"].ToString(), "1", ds.Tables[0].Rows[0]["imageurl"].ToString(), totalprice.ToString());
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
                        //dr["sno"] = sr + 1;
                        //dr["productid"] = ds.Tables[0].Rows[0]["productid"].ToString();
                        //dr["productname"] = ds.Tables[0].Rows[0]["productname"].ToString();
                        //dr["productimage"] = ds.Tables[0].Rows[0]["productimage"].ToString();
                        //dr["quantity"] = Request.QueryString["quantity"];
                        //dr["price"] = ds.Tables[0].Rows[0]["price"].ToString();
                        //int price = Convert.ToInt16(ds.Tables[0].Rows[0]["price"].ToString());
                        //int quantity = Convert.ToInt16(Request.QueryString["quantity"].ToString());
                        //int totalprice = price * quantity;
                        //dr["totalprice"] = totalprice;

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
                       savedcartdetail(sr + 1, ds.Tables[0].Rows[0]["productid"].ToString(), ds.Tables[0].Rows[0]["productcategory"].ToString(), ds.Tables[0].Rows[0]["productname"].ToString(), ds.Tables[0].Rows[0]["productdescription"].ToString(), ds.Tables[0].Rows[0]["unitprice"].ToString(), "1", ds.Tables[0].Rows[0]["imageurl"].ToString(), totalprice.ToString());
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
            Response.Redirect("Cart.aspx");
        }

        //clear cart
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["buyitems"] = null;
            clearsavedcart();
        }

        //checkout button
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Session["buyitems"] = null;
            //clearsavedcart();
            //Response.Redirect("OrderPlaced.aspx");
            Response.Redirect("PlaceOrder.aspx");
        }

        //functions
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
            Response.Redirect("Cart.aspx");
        }

        private void savedcartdetail(int no, String productid, String productcategory, String productname, String productdescription, String unitprice, String productquantity, String imageurl,  String totalprice)
        {
            String query = "insert into cart(no,productid,productcategory,productname,productdescription,unitprice,productquantity,imageurl,totalprice,username) values(" + no + ",'" + productid + "','" + productcategory + "','" + productname + "','" + productdescription +"','"+ unitprice + "','" + productquantity + "','" + imageurl + "','" + totalprice + "','" + Session["username"].ToString() + "')";
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

//change cartt to  Cart 2 instances