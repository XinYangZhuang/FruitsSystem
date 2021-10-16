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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!this.IsPostBack){
                DataList1.DataSource = Business.FruitBusiness.ShowHotFruit();
                DataList1.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Session["Detail_FruitId"] = btn.CommandArgument.ToString();
            Response.Redirect("FruitDetailPanel.aspx");
            //Response.Write("<script>alert(" + btn.CommandArgument.ToString() + ")</script>");
        }
        //protected void AllGirdview_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //Session["Detail_FruitId"] = AllGirdview.Rows[AllGirdview.SelectedIndex].Cells[1].Text.Trim();
        //    //Response.Redirect("FruitDetailPanel.aspx");


        //    Response.Redirect("FruitDetailPanel.aspx?Detail_FruitId=" + AllGirdview.Rows[AllGirdview.SelectedIndex].Cells[1].Text.Trim());



        //}

     
    }
}