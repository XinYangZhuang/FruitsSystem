using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class FruitView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                DataList1.DataSource = Business.FruitBusiness.ShowAllFriitTable();
                DataList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Session["Detail_FruitId"] = btn.CommandArgument.ToString();
            Response.Redirect("FruitDetailPanel.aspx");
        }
    }
}