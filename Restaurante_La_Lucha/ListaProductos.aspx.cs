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
        public int cantidad;
        public double valor, precio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Label2.Text = Session["Usuario"].ToString();
                Label3.Text = Label2.Text;
                if (!Page.IsPostBack)
                {
                    cantidad = 0;
                    valor = 0.00;
                }
                else
                {
                    cantidad = Convert.ToInt32(Label1.Text);
                    valor = Convert.ToDouble(Label10.Text);
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
            Button btn = (Button)(sender);
            string yourValue = btn.CommandName;
            valor = valor + Convert.ToDouble(yourValue);
            Label10.Text = valor.ToString();
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