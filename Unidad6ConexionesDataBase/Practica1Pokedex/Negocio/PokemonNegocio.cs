using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class PokemonNegocio
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
                comando.CommandText = "select p.Numero,p.Nombre,p.Descripcion,e.Id IdTipo,e.Descripcion Tipo,d.Id IdDebilidad,d.Descripcion Debilidad,p.UrlImagen url from POKEMONS p, ELEMENTOS e,ELEMENTOS d where e.Id=p.IdTipo and d.Id=p.IdDebilidad\r\n";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.nombre = (string)lector["Nombre"];
                    aux.numero = (int)lector["Numero"];
                    aux.descripcion = (string)lector["Descripcion"];
                    aux.tipo = new Elemento();
                    aux.tipo.id = (int)lector["IdTipo"];
                    aux.tipo.descripcion = (string)lector["Tipo"];
                    aux.debilidad = new Elemento();
                    aux.debilidad.id = (int)lector["IdDebilidad"];
                    aux.debilidad.descripcion = (string)lector["Debilidad"];
                    if (!(lector["url"] is DBNull)) // leer si NO es null la celda en la que esta.
                        aux.urlImagen = (string)lector["url"];

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
        public void agregar(Pokemon pokemonNuevo)
        {
            AccesoDatos dato = new AccesoDatos();

            try
            {
                dato.setearConsultaDB("insert into POKEMONS(Numero,Nombre,Descripcion,IdTipo,IdDebilidad, Activo, UrlImagen ) values (" + pokemonNuevo.numero+ ",'"+pokemonNuevo.nombre+"','"+pokemonNuevo.descripcion+"',"+pokemonNuevo.tipo.id+",@debilidad,1,@url)");
                dato.ingresarParametros("@debilidad",pokemonNuevo.debilidad.id);
                dato.ingresarParametros("@url", pokemonNuevo.urlImagen);
                dato.ejecutarAccion();
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
