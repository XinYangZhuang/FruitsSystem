using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;

namespace 水果销售网站
{
    public partial class UserOrderPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                this.OrderDataTable.DataSource = Business.OrderBusiness.ShowUserOrder(Convert.ToInt32(Session["UserId"]));
                this.OrderDataTable.DataBind();
            }

        }

        protected void lbtn_Delete_Click(object sender, EventArgs e)
        {
            int row = ((GridViewRow)((LinkButton)sender).NamingContainer).RowIndex;
            string Id = OrderDataTable.Rows[row].Cells[0].Text;
            int i = OrderBusiness.DeleteOrder(Convert.ToInt32(Id));
            if (i == 1)
            {
                Response.Write("<script>alert('删除成功!');</script>");
                this.OrderDataTable.DataSource = Business.OrderBusiness.ShowUserOrder(Convert.ToInt32(Session["UserId"]));
                this.OrderDataTable.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败!');</script>");
            }
        }
        protected void OrderDataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void OrderDataTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.OrderDataTable.PageIndex = e.NewPageIndex;
            this.OrderDataTable.DataBind();

        }
    }
}