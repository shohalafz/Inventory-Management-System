using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;

namespace IMSPM
{
    public partial class Schedule : System.Web.UI.Page
    {
        static int seatbookno = -1;

       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               //RSchedule();
            }
        }

       // private void Schedule() => throw new NotImplementedException();

        protected void Button17_Click(object sender, EventArgs e)
        {
           

            string mainconn = ConfigurationManager.ConnectionStrings["Inventory Management SystemConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            // String query = "delete from [dbo].[ProductInverntory] (productid,productname,qty)" + " values(@productid,@productname,@qty)";
            String myquery = "Update [dbo].[RSchedule] set Status='B' where RdcNo=" + seatbookno;
            SqlConnection con = new SqlConnection(mainconn);
            //SqlConnection con = new SqlConnection(mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            Label1.Text = "Your RDCNo="+ seatbookno;
            //Response.Redirect("Schedule.aspx?RdcNo=" + seatbookno);
        }
        private void seatstatus()
        {
          

            string mainconn = ConfigurationManager.ConnectionStrings["Inventory Management SystemConnectionString"].ConnectionString;
            //SqlConnection sqlconn = new SqlConnection(mainconn);
            // String query = "delete from [dbo].[ProductInverntory] (productid,productname,qty)" + " values(@productid,@productname,@qty)";
            String myquery = "select * from [dbo].[RSchedule]";
            SqlConnection con = new SqlConnection(mainconn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = myquery;
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            int rows = ds.Tables[0].Rows.Count;
            int i = 0;
            while (i < rows)
            {
                String status;
                status = ds.Tables[0].Rows[i]["tatus"].ToString();
                if (status == "A")
                {
                    if (i == 0 && seatbookno - 1 != i)
                    {
                        Button1.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 1 && seatbookno - 1 != i)
                    {
                        Button2.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 2 && seatbookno - 1 != i)
                    {
                        Button3.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 3 && seatbookno - 1 != i)
                    {
                        Button4.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 4 && seatbookno - 1 != i)
                    {
                        Button5.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 5 && seatbookno - 1 != i)
                    {
                        Button6.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 6 && seatbookno - 1 != i)
                    {
                        Button7.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 7 && seatbookno - 1 != i)
                    {
                        Button8.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 8 && seatbookno - 1 != i)
                    {
                        Button9.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 9 && seatbookno - 1 != i)
                    {
                        Button10.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 10 && seatbookno - 1 != i)
                    {
                        Button11.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 11 && seatbookno - 1 != i)
                    {
                        Button12.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 12 && seatbookno - 1 != i)
                    {
                        Button13.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 13 && seatbookno - 1 != i)
                    {
                        Button14.BackColor = System.Drawing.Color.Gray;

                    }
                    if (i == 14 && seatbookno - 1 != i)
                    {
                        Button15.BackColor = System.Drawing.Color.Gray;

                    }
                    if (i == 15 && seatbookno - 1 != i)
                    {

                        Button16.BackColor = System.Drawing.Color.Gray;
                    }
                    if (i == 16 && seatbookno - 1 != i)
                    {

                        Button16.BackColor = System.Drawing.Color.Gray;
                    }

                }
                if (status == "B")
                {
                    if (i == 0)
                    {
                        Button1.BackColor = System.Drawing.Color.Red;
                        Button1.Enabled = false;
                    }
                    if (i == 1)
                    {
                        Button2.BackColor = System.Drawing.Color.Red;
                        Button2.Enabled = false;
                    }
                    if (i == 2)
                    {
                        Button3.BackColor = System.Drawing.Color.Red;
                        Button3.Enabled = false;
                    }
                    if (i == 3)
                    {
                        Button4.BackColor = System.Drawing.Color.Red;
                        Button4.Enabled = false;
                    }
                    if (i == 4)
                    {
                        Button5.BackColor = System.Drawing.Color.Red;
                        Button5.Enabled = false;
                    }
                    if (i == 5)
                    {
                        Button6.BackColor = System.Drawing.Color.Red;
                        Button6.Enabled = false;
                    }
                    if (i == 6)
                    {
                        Button7.BackColor = System.Drawing.Color.Red;
                        Button7.Enabled = false;
                    }
                    if (i == 7)
                    {
                        Button8.BackColor = System.Drawing.Color.Red;
                        Button8.Enabled = false;
                    }
                    if (i == 8)
                    {
                        Button9.BackColor = System.Drawing.Color.Red;
                        Button9.Enabled = false;
                    }
                    if (i == 9)
                    {
                        Button10.BackColor = System.Drawing.Color.Red;
                        Button10.Enabled = false;
                    }
                    if (i == 10)
                    {
                        Button11.BackColor = System.Drawing.Color.Red;
                        Button11.Enabled = false;
                    }
                    if (i == 11)
                    {
                        Button12.BackColor = System.Drawing.Color.Red;
                        Button12.Enabled = false;
                    }
                    if (i == 12)
                    {
                        Button13.BackColor = System.Drawing.Color.Red;
                        Button13.Enabled = false;
                    }
                    if (i == 13)
                    {
                        Button14.BackColor = System.Drawing.Color.Red;
                        Button14.Enabled = false;

                    }
                    if (i == 14)
                    {
                        Button15.BackColor = System.Drawing.Color.Red;
                        Button15.Enabled = false;

                    }
                    if (i == 15)
                    {

                        Button16.BackColor = System.Drawing.Color.Red;
                        Button16.Enabled = false;
                    }
                    if (i == 16)
                    {

                        Button16.BackColor = System.Drawing.Color.Red;
                        Button16.Enabled = false;
                    }

                }

                i = i + 1;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button1.BackColor = System.Drawing.Color.Green;
            //RSchedule();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            seatbookno = 2;
            Button2.BackColor = System.Drawing.Color.Green;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            seatbookno = 3;
            Button3.BackColor = System.Drawing.Color.Green;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            seatbookno = 4;
            Button4.BackColor = System.Drawing.Color.Green;

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            seatbookno = 5;
            Button5.BackColor = System.Drawing.Color.Green;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            seatbookno = 6;
            Button6.BackColor = System.Drawing.Color.Green;
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            seatbookno = 7;
            Button7.BackColor = System.Drawing.Color.Green;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            seatbookno = 8;
            Button8.BackColor = System.Drawing.Color.Green;
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            seatbookno = 9;
            Button9.BackColor = System.Drawing.Color.Green;
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            seatbookno = 10;
            Button10.BackColor = System.Drawing.Color.Green;
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button11.BackColor = System.Drawing.Color.Green;
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button12.BackColor = System.Drawing.Color.Green;
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button13.BackColor = System.Drawing.Color.Green;
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button14.BackColor = System.Drawing.Color.Green;
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button15.BackColor = System.Drawing.Color.Green;
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            seatbookno = 1;
            Button16.BackColor = System.Drawing.Color.Green;
        }
    }
}