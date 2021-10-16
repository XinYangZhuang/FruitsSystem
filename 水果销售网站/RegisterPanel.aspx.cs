using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Entity;
using System.IO;

namespace 水果销售网站
{
    public partial class RegisterPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 返回登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPanel.aspx");
        }

        /// <summary>
        /// 立即注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (this.tbx_account.Text.Trim() == "")
            {
                Response.Write("<script>alert('账号不能为空！')</script>");
                return;
            }
            if (this.tbx_adress.Text.Trim() == "")
            {
                Response.Write("<script>alert('地址不能为空！')</script>");
                return;
            }
            if (this.tbx_job.Text.Trim() == "")
            {
                Response.Write("<script>alert('工作不能为空！')</script>");
                return;
            }
            if (this.tbx_name.Text.Trim() == "")
            {
                Response.Write("<script>alert('姓名不能为空！')</script>");
                return;
            }
            if (this.tbx_sex.Text.Trim() == "")
            {
                Response.Write("<script>alert('性别不能为空！')</script>");
                return;
            }

            else
            {

                if (Business.UserBusiness.CheckUserName(tbx_account.Text.Trim()) <= 0)
                {

                    if (tbx_pass.ToString() == tbx_repass.ToString())
                    {
                        Users user = new Users();
                        user.U_Account = this.tbx_account.Text;
                        user.U_PassWord = this.tbx_pass.Text;
                        user.UserName = this.tbx_name.Text;
                        user.Job = this.tbx_job.Text;
                        user.Sex = this.tbx_sex.Text;
                        user.Adress = this.tbx_adress.Text;
                        if (!this.FileUpload1.HasFile)
                        {
                            Response.Write("<script>alert('请选择JPG文件!')</script>");
                            return;
                        }
                        string uploadfile = this.FileUpload1.FileName;
                        string fileextn = System.IO.Path.GetExtension(uploadfile);
                        if (fileextn.ToLower() == ".jpg" || fileextn.ToLower() == ".jpeg")
                        {
                            string dcty = "~image";
                            if (!Directory.Exists(Server.MapPath(dcty)))
                            {
                                Directory.CreateDirectory(Server.MapPath(dcty));
                            }
                            dcty += "/";
                            this.FileUpload1.SaveAs(Server.MapPath(dcty) + FileUpload1.FileName);
                            user.Head = "~/image/" + FileUpload1.FileName;
                            int i = UserBusiness.Register(user);
                            if (i == 1)
                            {
                                Response.Write("<script>alert('注册成功!');location.href='LoginPanel.aspx';</script>");
                            }
                            else
                            {
                                Response.Write("<script>alert('未知错误，登陆失败!')</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('两次密码输入不一致!')</script>");
                        }
                    }
                }
                else {
                    Response.Write("<script>alert('您输入的用户名称已存在!')</script>");
                }





            }
        }
    }
}