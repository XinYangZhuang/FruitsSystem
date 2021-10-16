using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class AdminDeleteFruit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
            }
            else
            {
                this.FruitDataTable.DataSource = Business.FruitBusiness.ShowFruitTable();
                this.FruitDataTable.DataBind();
            }

        }

        protected void lbtn_Delete_Click(object sender, EventArgs e)
        {
            int row = ((GridViewRow)((LinkButton)sender).NamingContainer).RowIndex;
            string Id = FruitDataTable.Rows[row].Cells[0].Text;
            int i = FruitBusiness.deleteFruit(Convert.ToInt32(Id));
            Response.Write("<script>alert(" + Id + ")</script>");
            if (i == 1)
            {
                Response.Write("<script>alert('删除成功!');</script>");
                this.FruitDataTable.DataSource = Business.FruitBusiness.ShowFruitTable();
                this.FruitDataTable.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败!');</script>");
            }
        }
        protected void FruitDataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void FruitDataTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.FruitDataTable.PageIndex = e.NewPageIndex;
            this.FruitDataTable.DataBind();

        }
    }
}