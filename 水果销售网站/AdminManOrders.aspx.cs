using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class AdminManOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                if (Session["AdminId"] == null)
                {
                    Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
                }
                else
                {
                    GridView1.DataSource = Business.OrderBusiness.SelectAllOrder();
                    GridView1.DataBind();
                }
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            Session["admin_orderid"] = lin.CommandArgument.ToString();
            Response.Redirect("AdminChangeOrderStatus.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string orderid = TextBox1.Text.Trim();
            GridView1.DataSource = Business.OrderBusiness.SelectOrderByOrderid(orderid);
            GridView1.DataBind();
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            if (Business.OrderBusiness.DeleteOrder(Convert.ToInt16(lin.CommandArgument)) > 0)
            {
                Response.Write("<script>alert('删除成功')</script>");
                GridView1.DataSource = Business.OrderBusiness.SelectAllOrder();
                GridView1.DataBind();
            }
            else {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
}