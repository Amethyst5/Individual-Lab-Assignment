using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Lab_3
{



    public partial class WebForm20 : System.Web.UI.Page
    {
        // SqlCommand cmd = new SqlCommand();
        // SqlConnection con = new SqlConnection();
        //static String imagelink;

        protected void Page_Load(object sender, EventArgs e)
        {
            // con.ConnectionString = ConfigurationManager.ConnectionStrings["Lab3ConnectionString"].ConnectionString;
            //con.Open();
            //if (!IsPostBack)
            //{
            //getproductid();
            //}
        }

        protected void Button1_Click(object sender, EventArgs e) //save
        {
            //Response.Redirect("Home.aspx");


            SqlConnection con = new SqlConnection("Data Source=LAPTOP-O9L1A028\\JHEANELL; Initial Catalog = Lab3; Integrated Security = True");
            if (FileUpload1.HasFile)
            {
                string strname = FileUpload1.FileName.ToString();
                FileUpload1.PostedFile.SaveAs(Server.MapPath("~/imgfile/") + strname);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductDetails values(" + TextBox7.Text + ", '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "','" + TextBox5.Text + "','"  + strname + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Label3.Visible = true;
                Label3.Text = "Image Uploaded successfully";
                TextBox7.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Plz upload the image!!!!";
            }



            /* if (uploadimage() == true)
                 {
                     String query = "insert into ProductDetails(productID,productCategory,productName,productDescription,unitPrice,imageUrl)values(" + TextBox7.Text + ", '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "','" + TextBox5 + "','" + TextBox6.Text + "','" + imagelink + "')";
                     String mycon = "Data Source =LAPTOP-O9L1A028\\JHEANELL; Initial Catalog = Lab3; Integrated Security = True";
                     SqlConnection con = new SqlConnection(mycon);
                     con.Open();
                     SqlCommand cmd = new SqlCommand();
                     cmd.CommandText = query;
                     cmd.Connection = con;
                     cmd.ExecuteNonQuery();
                     Label3.Text = "Product Has Been Successfully Saved";
                     getproductid();
                     TextBox7.Text = "";
                     TextBox2.Text = "";
                     TextBox3.Text = "";
                     TextBox4.Text = "";
                     TextBox5.Text = "";
                     TextBox6.Text = "";
                     //cmd.Parameters.AddWithValue("@productno", txtFn0.Text);
                     // cmd.Parameters.AddWithValue("@productID", TextBox1.Text);
                     //cmd.Parameters.AddWithValue("@productCategory", TextBox2.Text);
                     //cmd.Parameters.AddWithValue("@productName", TextBox3.Text);
                     //cmd.Parameters.AddWithValue("@productDescription", TextBox4.Text);
                     // cmd.Parameters.AddWithValue("@unitPrice", TextBox5.Text);
                     //cmd.Parameters.AddWithValue("@imageUrl", TextBox6.Text);

                     cmd.ExecuteNonQuery();



                 }

            }


            private Boolean uploadimage()
            {
                Boolean imagesaved = false;
                if (FileUpload1.HasFile == true)
                {

                    String contenttype = FileUpload1.PostedFile.ContentType;

                    if (contenttype == "image/jpeg")
                    {

                        FileUpload1.SaveAs(Server.MapPath("~/images/") + Label4.Text + ".jpg");
                        imagelink = "images/" + Label4.Text + ".jpg";
                        imagesaved = true;
                    }
                    else
                    {
                        Label3.Text = "Kindly Upload JPEG Format Image Only";
                    }

                }

                else
                {
                    Label3.Text = "You have not selected any file - Browse and Select File First";
                }

                return imagesaved;

            }
            public void getproductid()
            {
                String mycon = "Data Source =LAPTOP-O9L1A028\\JHEANELL; Initial Catalog = Lab3; Integrated Security = True";
                SqlConnection scon = new SqlConnection(mycon);
                String myquery = "select productid from ProductDetails";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = myquery;
                cmd.Connection = scon;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                scon.Close();
                if (ds.Tables[0].Rows.Count < 1)
                {
                    Label4.Text = "1001";

                }
                else
                {



                    String mycon1 = "Data Source = LAPTOP-O9L1A028\\JHEANELL; Initial Catalog = Lab3; Integrated Security = True";
                    SqlConnection scon1 = new SqlConnection(mycon1);
                    String myquery1 = "select max(productid) from ProductDetails";
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = myquery1;
                    cmd1.Connection = scon1;
                    SqlDataAdapter da1 = new SqlDataAdapter();
                    da1.SelectCommand = cmd1;
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    Label4.Text = ds1.Tables[0].Rows[0][0].ToString();
                    int a;
                    a = Convert.ToInt16(Label3.Text);
                    a = a + 1;
                    Label4.Text = a.ToString();
                    scon1.Close();
                }

            }

     */
        }

    }
}

       
   