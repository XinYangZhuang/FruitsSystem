using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class AdminManHotFruits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
            }
            else
            {
                this.FruitDataTable.DataSource = Business.FruitBusiness.ShowHotFruit();
                this.FruitDataTable.DataBind();
            }
        }

        protected void FruitDataTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.FruitDataTable.PageIndex = e.NewPageIndex;
            this.FruitDataTable.DataBind();

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            int i = Business.FruitBusiness.deletHotFruit(lin.CommandArgument.ToString());
            if (i > 0)
            {
                Response.Write("<script>alert('删除成功')</script>");
                this.FruitDataTable.DataSource = Business.FruitBusiness.ShowHotFruit();
                this.FruitDataTable.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
            


    }
}