using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurante
{
    public partial class TransaccionDePago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransaccionDePago.aspx");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        

        protected void Button2_Click(object sender, EventArgs e)
        {
            RadioButtonList1.Enabled = false;
            if (RadioButtonList1.SelectedItem.ToString() == "Tarjeta")
            {
                
                Panel1.Visible = true;

            }
            else
            {
                Panel1.Visible = false;
            }
            Panel2.Visible = true;
        }

        
    }
}