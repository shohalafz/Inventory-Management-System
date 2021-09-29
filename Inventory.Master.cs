using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMSPM
{
    public partial class Inventory : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LnkAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPage.aspx");
        }

        protected void LnkLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void LnkStockReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("StockReport.aspx");
        }

        protected void LnkStock_Click(object sender, EventArgs e)
        {
            Response.Redirect("Stock.aspx");
        }

        protected void LnkSchedule_Click(object sender, EventArgs e)
        {
            Response.Redirect("Schedule.aspx");
        }
    }
}