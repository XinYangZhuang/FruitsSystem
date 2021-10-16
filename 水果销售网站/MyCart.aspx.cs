using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class MyCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {    
            if (Session["UserId"] != null)
                {
                    GridView1.DataSource = Business.CartBusiness.ShowCart(Session["UserId"].ToString());
                    GridView1.DataBind();
                }
                else
                {
                    Response.Redirect("LoginPanel.aspx");
                }
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            if (Business.CartBusiness.DeleteCart(lin.CommandArgument.ToString()) > 0)
            {
                Response.Write("<script>alert('删除成功')</script>");
                GridView1.DataSource = Business.CartBusiness.ShowCart(Session["UserId"].ToString());
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            LinkButton lin=sender as LinkButton;
            object[] c = Business.CartBusiness.SearchCartInfo(lin.CommandArgument.ToString());
            int quantity = Convert.ToInt32(c[8]);
            int stock = Convert.ToInt32(c[4]);
            if (quantity <= stock)
            {
                Session["Friutid"] = c[7].ToString();
                Session["fid"] = c[7].ToString();
                Session["totalprice"] = c[1].ToString();
                Session["fname"] = c[0].ToString();
                Session["price"] = c[2].ToString();
                Session["quantity"] = quantity;
                Session["imageurl"] = c[3].ToString();
                Response.Redirect("UserConfirmOrderInfo.aspx");
            }
            else
            {
                Response.Write("<script>alert('库存数量不足')</script>");
            }
        }
    }
}