using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 水果销售网站
{
    public partial class UserLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["UserId"] != null)
            {
                LinkButton1.Visible = true;
                LinkButton2.Visible = true;
                LinkButton3.Visible = true;
                LinkButton4.Visible = true;
             }
           
        }
    }
}