using Restaurante.App_Code.DAL;
using Restaurante.App_Code.DAL.UsuariosDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurante
{
    public class UsuariosBLL
    {
        public UsuariosBLL()
        {

        }

        public static List<UsuariosDTO> MostrarTodosUsuarios()

        {
            List<UsuariosDTO> listarUsuarios = new List<UsuariosDTO>();
            App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter adaptador = new App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter();
            App_Code.DAL.UsuariosDS.USUARIOSDataTable tabla = adaptador.MostrarUsuarios();
            foreach (App_Code.DAL.UsuariosDS.USUARIOSRow filas in tabla)
            {
                listarUsuarios.Add(filaDTOUser(filas));
            }

            return listarUsuarios;
        }

        private static UsuariosDTO filaDTOUser(App_Code.DAL.UsuariosDS.USUARIOSRow filas)
        {
            UsuariosDTO objUser = new UsuariosDTO();
            objUser.COD_USER = filas.ID.ToString();
            objUser.NOM_USER = filas.nombre;
            objUser.APELLIDO_USER = filas.apellido;
            objUser.USER_NAME = filas.username;
            objUser.PASS_USER = filas.pass;
            objUser.EMAIL_USER = filas.email;

            return objUser;
        }

        public bool UserLog(string username, string pass)
        {
            App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter adaptador = new App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter();
            App_Code.DAL.UsuariosDS.USUARIOSDataTable tabla = adaptador.UserLogin(username, pass);
            if (tabla.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static UsuariosDTO MostrarUsuariosID(string cod_user)
        {
            App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter adaptador = new App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter();
            App_Code.DAL.UsuariosDS.USUARIOSDataTable tabla = adaptador.MostrarUsuariosID(Convert.ToInt32(cod_user));
            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            return filaDTOUser(tabla[0]);
        }

        public void InsertarUsuario(string nombre, string apellido, string username, string pass, string email)
        {
            App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter adaptador = new App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter();
            adaptador.Insert(nombre, apellido, username, pass, email);
        }

        public void BorrarRol(string CodUser)
        {
            App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter adaptador = new App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter();
            adaptador.Delete(Convert.ToInt32(CodUser));
        }

        public void ActualizarRol(string ID, string nombre, string apellido, string username, string pass, string email)
        {
            App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter adaptador = new App_Code.DAL.UsuariosDSTableAdapters.USUARIOSTableAdapter();
            adaptador.Update(nombre, apellido, username, pass, email, Convert.ToInt32(ID));
        }
    }
}