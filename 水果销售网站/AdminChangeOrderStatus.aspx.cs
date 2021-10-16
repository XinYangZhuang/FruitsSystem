using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class AdminChangeOrderStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                if (Session["AdminId"] == null)
                {
                    Response.Write("<script>alert('请登录');location.href='LoginPanel.aspx';</script>");
                }
                else
                {
                    object[] o = Business.OrderBusiness.SearchOrderDetail(Session["admin_orderid"].ToString());
                    lbl_orderid.Text = o[0].ToString();
                    lbl_fname.Text = o[12].ToString();
                    lbl_totalprice.Text = o[5].ToString();
                    lbl_pro.Text = o[6].ToString();
                    lbl_city.Text = o[7].ToString();
                    lbl_area.Text = o[8].ToString();
                    lbl_rece.Text = o[10].ToString();
                    lbl_phone.Text = o[11].ToString();
              
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string orderstate = DropDownList1.SelectedItem.Text;
            if (Business.OrderBusiness.UpdateOrderState(Session["admin_orderid"].ToString(), orderstate) > 0)
            {
                Response.Write("<script>alert('修改成功')</script>");
            }
            else {
                Response.Write("<script>alert('修改失败')</script>");
            }
        }
    }
}