using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMSPM
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                if (TextBox1.Text == "Admin" && TextBox2.Text == "Admin123")
                {
                    Session["Adminname"] = "Welcome" + TextBox1.Text;
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    Button1.Text = "Failed Login Frtails....";
                }
            }
        }
    }
}