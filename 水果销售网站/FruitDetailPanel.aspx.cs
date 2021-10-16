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
    public partial class FruitDetailPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack){
                if (Session["Detail_FruitId"] != null)
                {
                    
                        object[] o = FruitBusiness.SearchFruitById(Session["Detail_FruitId"].ToString());
                        tbx_name.Text = o[1].ToString();
                        tbx_class.Text = o[2].ToString();
                        tbx_price.Text = o[3].ToString();
                        tbx_info.Text = o[5].ToString();
                        tbx_time.Text = o[6].ToString();
                        tbx_amount.Text = o[7].ToString();
                        Image1.ImageUrl = o[4].ToString();
                        Session["Friutid"] = o[0];
                
                 
                }
                else
                {
                    //选择商品
                    Response.Write("<script>alert('请选择商品');location.href='Home.aspx';</script>");
                }
            }


            
        }

        protected void btn_Buy_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {


                if (Convert.ToInt32(TextBox1.Text.Trim()) <= Convert.ToInt32(tbx_amount.Text))
                {
                
                    Session["fid"] = Session["Friutid"].ToString();
                    Session["totalprice"] = Convert.ToInt32(TextBox1.Text.Trim()) * Convert.ToDouble(tbx_price.Text);
                    Session["fname"] =tbx_name.Text;
                    Session["price"] = tbx_price.Text;
                    Session["quantity"] = Convert.ToInt32(TextBox1.Text.Trim());
                    Session["imageurl"] = Image1.ImageUrl;
                    Response.Redirect("UserConfirmOrderInfo.aspx");
                }
                else {
                    Response.Write("<script>alert('库存数量不足')</script>");
                }
               

                //Orders orders = new Orders();
                //orders.FruitId = Convert.ToInt32(Session["Cache"]);
                //orders.UserId = Convert.ToInt32(Session["UserId"]);
                //orders.State = "提交订单";
                //int i = OrderBusiness.InsertOrder(orders);
                //if (i == 1)
                //{
                //    Response.Write("<script>alert('购买成功')</script>");
                //}
                //else
                //{
                //    Response.Write("<script>alert('购买失败')</script>");
                //}
            }
            else
            {
                Response.Write("<script>alert('请登陆')</script>");
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                Cart c = new Cart();
                c.Fruitid = Session["Friutid"].ToString();
                c.Userid = Session["UserId"].ToString();
                c.Quantity = TextBox1.Text.Trim();
                int i = CartBusiness.InsertCart(c);
                if (i == 1)
                {
                    Response.Write("<script>alert('添加成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('添加失败')</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('请登陆')</script>");
            }
        }
    }
}