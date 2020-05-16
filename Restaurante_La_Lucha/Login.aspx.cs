using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Restaurante
{
    public partial class Login : System.Web.UI.Page
    {
        App_Code.Encriptar encrip = new App_Code.Encriptar();
        UsuariosBLL userCurrent = new UsuariosBLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username, pass, passw;
            username = TextBox1.Text;
            pass = TextBox2.Text;
            passw = encrip.HashEncrip(pass);
            if (userCurrent.UserLog(username, passw))
            {
                HttpCookie COOKIE = new HttpCookie("se", TextBox1.Text);
                COOKIE.Expires = new DateTime(2030, 12, 31);
                Response.Cookies.Add(COOKIE);
                Session["Usuario"] = TextBox1.Text;
                Response.Redirect("index.aspx");
            }
            else
            {
                this.Page.Response.Write("<script language='JavaScript'>alert('Datos Incorrectos');</script>");
            }
        }
    }
}