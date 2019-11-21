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
    public partial class WebForm28 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = SqlDataSource1;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label1.Text = "";
            GridView1.EditRowStyle.BackColor = System.Drawing.Color.Orange;
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
            Label1.Text = "";
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //Label rollno = GridView1.Rows[e.RowIndex].FindControl("Label7") as Label;
            TextBox productid = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox productcategory = GridView1.Rows[e.RowIndex].FindControl("TextBox2") as TextBox;
            TextBox productname = GridView1.Rows[e.RowIndex].FindControl("TextBox3") as TextBox;
            TextBox productdescription = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            TextBox unitprice = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;
            //TextBox imageurl = GridView1.Rows[e.RowIndex].FindControl("TextBox5") as TextBox;

            String mycon = "Data Source=LAPTOP-O9L1A028\\Jheanell; Initial Catalog=Lab3; Integrated Security=True";
            String updatedata = "Update productdetails set  productcategory='" + productcategory.Text + "', productname='" + productname.Text + "', productdescription='" + productdescription.Text + "', unitprice='" + unitprice.Text + "' where productid='" + productid.Text +"'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "Row Data Has Been Updated Successfully";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label productid = GridView1.Rows[e.RowIndex].FindControl("Label3") as Label;
            //TextBox productid = GridView1.Rows[e.RowIndex].Cells[0].FindControl("TextBox1") as TextBox;
            String mycon = "Data Source=LAPTOP-O9L1A028\\Jheanell; Initial Catalog=Lab3; Integrated Security=True";
            String updatedata = "delete from productdetails where productid='" + productid.Text +"'";
            SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "Row Data Has Been Deleted Successfully";
            GridView1.EditIndex = -1;
            SqlDataSource1.DataBind();
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }
        
     /*  protected void LinkButton8_Click(object sender, EventArgs e)
       {
           

           TextBox productid = GridView1.FooterRow.FindControl("TextBox7") as TextBox;
           TextBox productcategory = GridView1.FooterRow.FindControl("TextBox8") as TextBox;
           TextBox productname = GridView1.FooterRow.FindControl("TextBox9") as TextBox;
           TextBox productdescription = GridView1.FooterRow.FindControl("TextBox10") as TextBox;
           TextBox unitprice = GridView1.FooterRow.FindControl("TextBox11") as TextBox;
           TextBox imageurl = GridView1.FooterRow.FindControl("TextBox12") as TextBox;

           String query = "insert into productdetails(productid,productcategory,productname,productdescription,unitprice) values('" + productid.Text + "','" + productcategory.Text + "','" + productname.Text + "','" + productdescription +"','" + unitprice + "')";
           String mycon = "Data Source=LAPTOP-O9L1A028\\Jheanell; Initial Catalog=Lab3; Integrated Security=true";
           SqlConnection con = new SqlConnection(mycon);
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = query;
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           Label1.Text = "New Row Inserted Successfully";
           SqlDataSource1.DataBind();
           GridView1.DataSource = SqlDataSource1;
           GridView1.DataBind();
       }*/
    }
}