using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab_3
{
    public partial class WebForm18 : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            con.ConnectionString = ConfigurationManager.ConnectionStrings["Lab3ConnectionString"].ConnectionString;
            con.Open();

            lblRegisteredUsers0.Text = "Registered Users:" + Application["userCount"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Registration" + "(FirstName,LastName,Email,Dob,Number,Password,Username)values(@FirstName,@LastName,@Email,@Dob,@Number,@Password,@Username)", con);
            //SqlCommand cmd = new SqlCommand("insert into PurpleDaez0" + "(Date) values(@Date)", con);
            cmd.Parameters.AddWithValue("@FirstName", txtFn0.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLn0.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail0.Text);
            cmd.Parameters.AddWithValue("@Dob", TextBox1.Text);
            cmd.Parameters.AddWithValue("@Number", txtNum0.Text);
            cmd.Parameters.AddWithValue("@Password", txtP3.Text);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);

            cmd.ExecuteNonQuery();

            //Label1.Text = "--inserted--";




            Session["user"] = txtFn0.Text;
            Session["name"] = txtLn0.Text;

            int uCount = (int)Application["userCount"];
            uCount++;
            Application["userCount"] = uCount;


            Response.Redirect("Login.aspx");
        }
    }
}