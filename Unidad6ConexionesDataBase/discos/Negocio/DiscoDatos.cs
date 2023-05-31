using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class DiscoDatos
    {
        public List<Disco> listar()
        {
            List<Disco> listaDisco= new List<Disco>();
            AccesoDatos datos= new AccesoDatos();

            try
            {
                datos.setearConsulta("select d.Titulo Titulo,d.CantidadCanciones CantidadCanciones,d.FechaLanzamiento FechaLanzamiento,e.Descripcion Descripcion,d.UrlImagenTapa UrlImagenTapa from DISCOS d,ESTILOS e where d.IdEstilo=e.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.titulo = (string)datos.Lector["Titulo"];
                    aux.cantidadDeCanciones = (int)datos.Lector["CantidadCanciones"];
                    aux.fechaDeLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.estilo = new Estilo();
                    aux.estilo.descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    listaDisco.Add(aux);
                }

                return listaDisco;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
    }
}
