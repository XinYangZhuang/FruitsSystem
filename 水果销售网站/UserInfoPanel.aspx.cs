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
    public partial class UserInfoPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                Users user = new Users();
                user.Id = Convert.ToInt32(Session["UserId"]);
                object[] obj = Business.UserBusiness.SearchUserById(user);
                tbx_account.Text = obj[1].ToString();
                tbx_name.Text = obj[2].ToString();
                tbx_sex.Text = obj[3].ToString();
                tbx_job.Text = obj[4].ToString();
                tbx_adress.Text = obj[5].ToString();
                Image1.ImageUrl = obj[6].ToString();
            }
            else {
                Response.Write("<script>alert('请登陆');location.href='LoginPanel.aspx';</script>");
            }
        }

        /// <summary>
        /// 退出登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["UserId"] = null;
            Response.Redirect("LoginPanel.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserOrderPanel.aspx");
        }
    }
}