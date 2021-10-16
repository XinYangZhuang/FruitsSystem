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
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] != null)
            {
                Response.Write("<script>alert('不可重复登陆!');location.href='AdminInsertFruit.aspx';</script>");
            }

        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Login_Click(object sender, EventArgs e)
        {
            
            if (this.TextBox1.Text.Trim() == ""||this.TextBox2.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入账号和密码！')</script>");
                return;
            }
            
            else
            {
                Admins admin = new Admins();
                admin.A_Account = this.TextBox1.Text.Trim();
                admin.A_PassWord = this.TextBox2.Text.Trim();
                int i = AdminBusiness.AdminLogin(admin);
                if (i == 0)
                {
                    Session["AdminId"] = "Admin";
                    Response.Write("<script>alert('登陆成功!');location.href='AdminInsertFruit.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('账号名或密码不正确，登陆失败!')</script>");
                }
            }
        }
    }
}