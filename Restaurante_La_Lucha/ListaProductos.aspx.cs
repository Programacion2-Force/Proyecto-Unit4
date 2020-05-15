using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Restaurante
{
    public partial class ListaProductos : System.Web.UI.Page
    {
        int cantidad;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Label2.Text = Session["Usuario"].ToString();
                if (!Page.IsPostBack)
                {
                    cantidad = 0;
                }
                else
                {
                    cantidad = Convert.ToInt32(Label1.Text);
                }
            }
            else
            {
                Response.Redirect("index.aspx");
            }
        }

        public void CargarProducto()
        {
            cantidad = cantidad + 1;
            Label1.Text = cantidad.ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            CargarProducto();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CargarProducto();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CargarProducto();
        }
    }
}