using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;


namespace IMSPM
{
    public partial class Stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Inventory Management SystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "insert into [dbo].[ProductInverntory] (productid,productname,qty)" + " values(@productid,@productname,@qty)";
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@productid", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@productname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@qty", TextBox3.Text);
            //sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();

            Label1.Text = "Data Has been Inserted";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Inventory Management SystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            // String query = "delete from [dbo].[ProductInverntory] (productid,productname,qty)" + " values(@productid,@productname,@qty)";
            String query = "Update [dbo].[StudentInformation] set productname='" + TextBox2.Text + "', qty='" + TextBox3.Text;
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@productid", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@productname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@qty", TextBox3.Text);
            //sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();

            Label1.Text = "Oparation Has been Updated";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string mainconn = ConfigurationManager.ConnectionStrings["Inventory Management SystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "delete from [dbo].[ProductInverntory] (productid,productname,qty)" + " values(@productid,@productname,@qty)";
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

            sqlcomm.Parameters.AddWithValue("@productid", TextBox1.Text);
            //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
            sqlcomm.Parameters.AddWithValue("@productname", TextBox2.Text);
            sqlcomm.Parameters.AddWithValue("@qty", TextBox3.Text);
            //sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);

            sqlcomm.ExecuteNonQuery();

            Label1.Text = "Oparation Has been Deleted";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = "Oparation Has been Cancell";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            string mainconn = ConfigurationManager.ConnectionStrings["Inventory Management SystemConnectionString"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(mainconn);
            String query = "Select * from [dbo].[ProductInverntory]";
            //  String mycon = "Data Source=VIKAS-PC\\SQLEXPRESS; Initial Catalog=RegistrationFormData; Integrated Security=true";
            // SqlConnection con = new SqlConnection(mycon);
            sqlconn.Open();
            //cmd.Connection = sqlconn;
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);

         
            /**
             * sqlcomm.Parameters.AddWithValue("@rollno", TextBox1.Text);
             //sqlcomm.Parameters.AddWithValue("@gender", DropDownList1.Text);
             sqlcomm.Parameters.AddWithValue("@sname", TextBox2.Text);
             sqlcomm.Parameters.AddWithValue("@fathername", TextBox3.Text);
             sqlcomm.Parameters.AddWithValue("@mothername", TextBox4.Text);
            **/

            sqlcomm.ExecuteNonQuery();
            
           
                Label2.Text = "Data has been Found";
            
            
           

            TextBox2.Enabled = true;
            TextBox3.Enabled = true;

        }
    }
}