using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class UserInsertAddress : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["UserId"] != null)
                {

                    ddlProvince.DataSource = Business.AddressBusiness.GetProvincesTable();
                    ddlProvince.DataTextField = "name"; 
                    ddlProvince.DataValueField = "code";
                    ddlProvince.DataBind();

                    ddlCity.DataSource = Business.AddressBusiness.GetCityTable("110000");
                    ddlCity.DataTextField = "name";
                    ddlCity.DataValueField = "code";
                    ddlCity.DataBind();

                    ddlArea.DataSource = Business.AddressBusiness.GetAreaTable("110100");
                    ddlArea.DataTextField = "name";
                    ddlArea.DataValueField = "code";
                    ddlArea.DataBind();
                }
            }
        }

        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCity.DataSource = Business.AddressBusiness.GetCityTable(ddlProvince.SelectedValue);//根据选择的值进行查找城市
            ddlCity.DataTextField = "name";//绑定相应的字段名
            ddlCity.DataValueField = "code";//绑定相应的字段名
            ddlCity.DataBind();

            ddlArea.DataSource = Business.AddressBusiness.GetAreaTable(ddlCity.SelectedValue);//根据选择城市的值进行查找区
            ddlArea.DataTextField = "name";//绑定相应的字段名
            ddlArea.DataValueField = "code";//绑定相应的字段名
            ddlArea.DataBind();
        }

        protected void ddlCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlArea.DataSource = Business.AddressBusiness.GetAreaTable(ddlCity.SelectedValue);//根据选择的值进行查找区
            ddlArea.DataTextField = "name";//绑定相应的字段名
            ddlArea.DataValueField = "code";//绑定相应的字段名
            ddlArea.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Address a = new Address();
            string province = ddlProvince.SelectedItem.Text;
            string city = ddlCity.SelectedItem.Text;
            string area = ddlArea.SelectedItem.Text;
            a.Pro = province;
            a.City = city;
            a.Area = area;
            a.Userid = Session["UserId"].ToString();
            a.Rece = txt_receiver.Text.Trim();
            a.Phone = txt_phone.Text.Trim();
            a.Address1 = txt_address.Text.Trim();
            int k = Business.AddressBusiness.InsertAddress(a);
            if (k > 0)
            {
                Response.Write("<script>alert('插入成功')</script>");
            }
            else
            {
                Response.Write("<script>alert('插入失败')</script>");
            }
        }



    }
}