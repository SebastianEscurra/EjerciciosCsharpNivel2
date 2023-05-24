using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conexionaDBejercicio2
{
    internal class DiscoDatos
    {
        public List<Disco> listar()
        {
            List<Disco> discos = new List<Disco>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server= .\\SQLexpress;database=DISCOS_DB;integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select d.Titulo,d.CantidadCanciones,d.FechaLanzamiento,e.Descripcion Estilo,d.UrlImagenTapa  from DISCOS d , ESTILOS e where d.IdEstilo=e.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Disco aux = new Disco();

                    aux.titulo = (string)lector["Titulo"];
                    aux.cantidadDeCanciones = (int)lector["CantidadCanciones"];
                    aux.fechaDeLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.estilo = new Estilo();
                    aux.estilo.descripcion = (string)lector["Estilo"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    discos.Add(aux);
                }
                conexion.Close();

                return discos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}
