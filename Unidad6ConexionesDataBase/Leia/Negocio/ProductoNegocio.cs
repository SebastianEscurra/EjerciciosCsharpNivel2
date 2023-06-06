using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {

        public List<Producto> listar()
        {
            AccesoDatos dato=new AccesoDatos();
            List<Producto> productos = new List<Producto>();

            try
            {
                dato.setearConsulta("select Id,Nombre,Precio,Descripcion,URLimagen from Producto");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.id = (int)dato.Lector["Id"];
                    aux.nombre = (string)dato.Lector["Nombre"];
                    aux.precio = (double)dato.Lector["Precio"];
                    aux.descripcion = (string)dato.Lector["Descripcion"];
                    if (!(dato.Lector["URLimagen"] is DBNull))
                        aux.UrlImagen = (string)dato.Lector["URLimagen"];
                    productos.Add(aux);
                }

                return productos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }

        }

        
    }
}
