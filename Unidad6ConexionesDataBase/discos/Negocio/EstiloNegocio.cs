using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> listar()
        {
            AccesoDatos dato = new AccesoDatos();
            List<Estilo> estilos = new List<Estilo>();

            try
            {
                dato.setearConsulta("select Id,Descripcion from ESTILOS");
                dato.ejecutarLectura();

                while(dato.Lector.Read())
                {
                    Estilo aux = new Estilo();

                    aux.id = (int)dato.Lector["Id"];
                    aux.descripcion = (string)dato.Lector["Descripcion"];

                    estilos.Add(aux);
                }

                return estilos;
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
