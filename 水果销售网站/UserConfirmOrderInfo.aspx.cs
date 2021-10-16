using Business;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class UserConfirmOrderInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                GridView2.DataSource = Business.AddressBusiness.GetAddressByUserid(Session["UserId"].ToString());
                GridView2.DataBind();

    
                lbl_fname.Text = Session["fname"].ToString();
                lbl_quantity.Text = Session["quantity"].ToString();
                lbl_price.Text = Session["price"].ToString();
                lbl_totalprice.Text = Session["totalprice"].ToString();
                Image1.ImageUrl = Session["imageurl"].ToString();

            }
            else
            {
                Response.Redirect("LoginPanel.apsx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (lbl_address.Text == "请选择收货地址")
            {
                Response.Write("<script>alert('请您选择收货地址')</script>");
            }
            else
            {
                Orders orders = new Orders();
                orders.FruitId = Convert.ToInt32(Session["Friutid"]);
                orders.UserId = Convert.ToInt32(Session["UserId"]);
                orders.State = "提交订单";
                orders.Quantity = Session["quantity"].ToString();
                orders.Totalprice = Session["totalprice"].ToString();
                orders.Pro = Session["user_pro"].ToString();
                orders.City = Session["user_city"].ToString();
                orders.Area = Session["user_area"].ToString();
                orders.Address = Session["user_address"].ToString();
                orders.Receiver = Session["user_receiver"].ToString();
                orders.Phone = Session["user_phone"].ToString();
                //orders.Pro=
                int i = OrderBusiness.InsertOrder(orders);
                
                if (i == 1)
                {
                    int j = OrderBusiness.UpdateStock(Session["Friutid"].ToString(), Convert.ToInt32(Session["quantity"].ToString()));
                    Response.Write("<script>alert('购买成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('购买失败')</script>");
                }
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            LinkButton lin = sender as LinkButton;
            object[] o = Business.AddressBusiness.SearchAddress(lin.CommandArgument.ToString());
            lbl_address.Text = o[1].ToString() + o[2].ToString() + o[3].ToString() + o[4].ToString();
            lbl_receiver.Text = o[5].ToString();
            lbl_phone.Text = o[6].ToString();
            Session["user_pro"] = o[1].ToString();
            Session["user_city"] = o[2].ToString();
            Session["user_area"] = o[3].ToString();
            Session["user_address"] = o[4].ToString();
            Session["user_receiver"] = o[5].ToString();
            Session["user_phone"] = o[6].ToString();
        }
    }
}