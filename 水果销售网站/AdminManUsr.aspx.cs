using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class AdminManUsr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
            }
            else
            {
                GridView1.DataSource = Business.UserBusiness.ShowUserTable();
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string account = TextBox1.Text.Trim();
            GridView1.DataSource = Business.UserBusiness.SearcheUserName(account);
            GridView1.DataBind();

        }

  

        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            if (Business.UserBusiness.DeleteUserInfo(lin.CommandArgument.ToString()) > 0)
            {
                Response.Write("<script>alert('删除成功')</script>");
                GridView1.DataSource = Business.UserBusiness.ShowUserTable();
                GridView1.DataBind();
            }
            else
            {
                Response.Write("<script>alert('删除失败')</script>");
            }
        }
    }
}