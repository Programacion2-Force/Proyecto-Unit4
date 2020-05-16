using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurante
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user;
            if (Session["Usuario"] != null)
            {
                user = Session["Usuario"].ToString();
                Label1.Text = user;
                Button1.Visible = false;
            }
            else
            {
                Label1.Text = "";
                Button1.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("Login.aspx");
        }
    }
}