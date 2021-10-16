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
    public partial class AdminUpdateFruit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
            }
            else
            {
                this.FruitDataTable.DataSource = Business.FruitBusiness.ShowFruitTable();
                this.FruitDataTable.DataBind();
            }
        }

        //protected void FruitDataTable_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string ID = FruitDataTable.Rows[FruitDataTable.SelectedIndex].Cells[1].Text.Trim();
        //    object[] obj = FruitBusiness.SearchFruitById(ID);
        //    Session["fruitid"] = obj[0];
        //    tbx_name.Text = obj[1].ToString();
        //    tbx_class.Text = obj[2].ToString();
        //    tbx_price.Text = obj[3].ToString();
        //    tbx_info.Text = obj[5].ToString();
        //    tbx_count.Text = obj[7].ToString();

        //}

        protected void FruitDataTable_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.FruitDataTable.PageIndex = e.NewPageIndex;
            this.FruitDataTable.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Entity.Fruits fruit = new Fruits();
            fruit.Id = Convert.ToInt32(Session["fruitid"]);
            Session["fruitid" ]= null;
            if (this.tbx_class.Text.Trim() == "" || this.tbx_price.Text.Trim() == "")
            {
                Response.Write("<script>alert('信息不完整!');</script>");
            }
            else
            {
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
                string uploadfile = this.FileUpload1.FileName;
                string fileextn = System.IO.Path.GetExtension(uploadfile);
                if (fileextn.ToLower() == ".jpg" || fileextn.ToLower() == ".jpeg")
                {
                    string dcty = "~/Image";
                    if (!Directory.Exists(Server.MapPath(dcty)))
                    {
                        Directory.CreateDirectory(Server.MapPath(dcty));
                    }
                    dcty += "/";
                    this.FileUpload1.SaveAs(Server.MapPath(dcty) + FileUpload1.FileName); 
                    fruit.F_Image = "~/Image/" + FileUpload1.FileName;

                    int i = FruitBusiness.UpdataFruit(fruit);
                    if (i == 1)
                    {
                        Response.Write("<script>alert('更新成功!');location.href='AdminUpdateFruit.aspx';</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('未知错误，更新失败!')</script>");
                    }
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            int i = FruitBusiness.InsertHot(lin.CommandArgument.ToString());
            if (i == 1)
            {
                Response.Write("<script>alert('更新成功!');location.href='AdminUpdateFruit.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('未知错误，更新失败!')</script>");
            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            string ID =lin.CommandArgument.ToString();
            object[] obj = FruitBusiness.SearchFruitById(ID);
            Session["fruitid"] = obj[0];
            tbx_name.Text = obj[1].ToString();
            tbx_class.Text = obj[2].ToString();
            tbx_price.Text = obj[3].ToString();
            tbx_info.Text = obj[5].ToString();
            tbx_count.Text = obj[7].ToString();
        }
    }

}