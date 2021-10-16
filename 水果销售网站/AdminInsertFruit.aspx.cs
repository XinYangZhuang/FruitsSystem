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
    public partial class AdminInsertFruit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
            }
            else
            {
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            if (this.tbx_class.Text.Trim() == "")
            {
                Response.Write("<script>alert('水果类型不能为空！')</script>");
                return;
            }
            if (this.tbx_count.Text.Trim() == "")
            {
                Response.Write("<script>alert('水果数量不能为空！')</script>");
                return;
            }
            if (this.tbx_info.Text.Trim() == "")
            {
                Response.Write("<script>alert('水果简介不能为空！')</script>");
                return;
            }
            if (this.tbx_name.Text.Trim() == "")
            {
                Response.Write("<script>alert('水果名不能为空！')</script>");
                return;
            }
            if (this.tbx_price.Text.Trim() == "")
            {
                Response.Write("<script>alert('水果价格不能为空！')</script>");
                return;
            }

            else
            {
                Fruits fruit = new Fruits();
                fruit.F_Name = tbx_name.Text;
                fruit.F_Price = Convert.ToInt32(tbx_price.Text);
                fruit.F_Info = tbx_info.Text;
                fruit.F_Count = Convert.ToInt32(tbx_count.Text);
                fruit.F_Class = tbx_class.Text;
                fruit.F_CreateTime = DateTime.Now;
                if (!this.FileUpload1.HasFile)
                {
                    Response.Write("<script>alert('请选择JPG文件!')</script>");
                    return;
                }
                string uploadfile = this.FileUpload1.FileName;//文件名
                string fileextn = System.IO.Path.GetExtension(uploadfile);//扩展名
                if (fileextn.ToLower() == ".jpg" || fileextn.ToLower() == ".jpeg")
                {
                    string dcty = "~/image";//相对路径
                    if (!Directory.Exists(Server.MapPath(dcty)))
                    {
                        Directory.CreateDirectory(Server.MapPath(dcty));
                    }
                    dcty += "/";
                    this.FileUpload1.SaveAs(Server.MapPath(dcty) + FileUpload1.FileName);
                    fruit.F_Image = "~/image/" + FileUpload1.FileName;
                    int i = FruitBusiness.InsertFruit(fruit);
                    if (i == 1)
                    {
                        Response.Write("<script>alert('添加成功!');location.href='AdminInsertFruit.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('未知错误，添加失败!')</script>");
                    }

                }

            }
        }
    }
}