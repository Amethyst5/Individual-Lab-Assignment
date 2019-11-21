using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Lab_3
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CreateRoleButton_Click(object sender, EventArgs e)
        {
            //string newRoleName = RoleName.Text.Trim();

            //if (!Roles.RoleExists(newRoleName))
            // Create the role
            //   Roles.CreateRole(newRoleName);

            // RoleName.Text = string.Empty;
            Response.Redirect("Home.aspx");
        }
    }
}