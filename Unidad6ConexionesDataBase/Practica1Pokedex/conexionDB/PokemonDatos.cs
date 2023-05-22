using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace conexionDB
{
    internal class PokemonDatos
    {
        public List<Pokemon> obtenerListaPokemon()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "server= (local)\\SQLexpress;database=POKEDEX_DB;integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.Numero,p.Nombre,p.Descripcion,e.Descripcion Tipo from POKEMONS p, ELEMENTOS e where p.IdTipo=e.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.nombre = (string)lector["Nombre"];
                    aux.numero = (int)lector["Numero"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.tipo = lector.GetString(3);

                    pokemons.Add(aux);
                }
                conexion.Close();
                return pokemons;
            }
            catch (Exception ex)    
            {

                throw ex;
            }
        }
    }
}
