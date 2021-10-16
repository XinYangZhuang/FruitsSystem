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
    public partial class LoginPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session对象存储特定用户会话所需的属性及配置信息。这样，当用户在应用程序的Web页之间跳转时，存储在Session对象中的变量将不会丢失，而是在整个用户会话中一直存在下去
            // 一般 我们用Session 来判断当前的用户是否登录 或者用于信息的传递
            if (Session["UserId"] != null)
            {
                Response.Write("<script>alert('不可重复登陆!');location.href='UserInfoPanel.aspx';</script>");
            }
        }

        /// <summary>
        /// 注册页面跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPanel.aspx");
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btn_Login_Click(object sender, EventArgs e)
        {         
          
            if (this.TextBox1.Text.Trim() == "" || this.TextBox2.Text.Trim() == "")
            {
                Response.Write("<script>alert('请输入账号密码!')</script>");
            }
            else
            {
                Entity.Users user = new Users();
                user.U_Account = this.TextBox1.Text.Trim();
                user.U_PassWord = this.TextBox2.Text.Trim();
                int i = UserBusiness.Login(user);
                if (i == 1)
                {
                    object[] us = UserBusiness.SearchUser(user);
                    Session["UserId"] = us[0];
                    Response.Write("<script>alert('登陆成功!');location.href='UserInfoPanel.aspx';</script>");
                }
                else
                {
                    Response.Write("<script>alert('账号名或密码不正确，登陆失败!')</script>");
                }
            }
        }
    }
}