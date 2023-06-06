using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader _lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion=new SqlConnection("server= (local)\\SQLexpress;database=POKEDEX_DB;integrated security=true;");
            comando = new SqlCommand();
        }

        public void setearConsultaDB(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion; 
            try
            {
            conexion.Open();
            lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void cerrarConexion()
        {
            if (lector!= null)
            lector.Close();

            conexion.Close();
        }
        public void ejecutarAccion()
        {
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ingresarParametros(string nombre, Object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
    }
}
