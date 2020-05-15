using Restaurante.App_Code.DAL;
using Restaurante.App_Code.DAL.ProductosDSTableAdapters;
using Restaurante.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurante
{
    public class ProductosBLL
    {
        public ProductosBLL()
        {

        }
        public static List<ClsProductos> MostrarTodosProductos()

        {
            List<ClsProductos> listarProductos = new List<ClsProductos>();
            App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter adaptador = new App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter();
            App_Code.DAL.ProductosDS.ProductoDataTable tabla = adaptador.MostrarProductos();

            foreach (App_Code.DAL.ProductosDS.ProductoRow filas in tabla)
            {
                listarProductos.Add(filaDTOProducto(filas));
            }

            return listarProductos;
        }

        private static ClsProductos filaDTOProducto(App_Code.DAL.ProductosDS.ProductoRow filas)
        {
            ClsProductos objProducto = new ClsProductos();

            objProducto.nombre = filas.Nombre;
            objProducto.idTipoProduc = filas.IdTipoProducto;
            objProducto.precio = filas.Precio;
            objProducto.descripcion = filas.Descripcion;
            objProducto.imagen = filas.imagen;

            return objProducto;
        }

        public static ClsProductos MostrarProductoID(int id)
        {
            App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter adaptador = new App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter();
            App_Code.DAL.ProductosDS.ProductoDataTable tabla = adaptador.MostrarProductoID(id);

            if (tabla.Rows.Count == 0)
            {
                return null;
            }
            return filaDTOProducto(tabla[0]);

        }

        public void InsertarProducto(string Nombre, int IdTipoProducto, decimal Precio, string Descripcion, string imagen)
        {
            App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter adaptador = new App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter();
            adaptador.Insert(Nombre, IdTipoProducto, Precio, Descripcion, imagen);
        }

        public void EliminarProducto(int id)
        {
            App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter adaptador = new App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter();
            adaptador.Delete(id);
        }

        public void ActualizarProducto(int id, string Nombre, int IdTipoProducto, decimal Precio, string Descripcion, string imagen)
        {
            App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter adaptador = new App_Code.DAL.ProductosDSTableAdapters.ProductoTableAdapter();
            adaptador.Update(Nombre, IdTipoProducto, Precio, Descripcion, imagen, id);
        }
    }
}