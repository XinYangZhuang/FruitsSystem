using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class UserManageAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {

                GridView1.DataSource = Business.AddressBusiness.GetAddressByUserid(Session["UserId"].ToString());
                GridView1.DataBind();
            }
            else
            {
                Response.Redirect("LoginPanel.apsx");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            if (Business.AddressBusiness.DeleteAddressByID(lin.CommandArgument.ToString()) > 0)
            {
                Response.Write("<script>alert('删除成功')</script>");
                GridView1.DataSource = Business.AddressBusiness.GetAddressByUserid(Session["userid"].ToString());
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
}