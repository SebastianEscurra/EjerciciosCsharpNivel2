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
        public List<Pokemon> listar()
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "server= (local)\\SQLexpress;database=POKEDEX_DB;integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.Id ,p.Numero,p.Nombre,p.Descripcion,e.Id IdTipo,e.Descripcion Tipo,d.Id IdDebilidad,d.Descripcion Debilidad,p.UrlImagen UrlImagen from POKEMONS p, ELEMENTOS e,ELEMENTOS d where e.Id=p.IdTipo and d.Id=p.IdDebilidad and Activo=1";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Numero = (int)lector["Numero"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.Tipo = new Elemento();
                    aux.Tipo.id = (int)lector["IdTipo"];
                    aux.Tipo.descripcion = (string)lector["Tipo"];
                    aux.Debilidad = new Elemento();
                    aux.Debilidad.id = (int)lector["IdDebilidad"];
                    aux.Debilidad.descripcion = (string)lector["Debilidad"];
                    if (!(lector["UrlImagen"] is DBNull)) // leer si NO es null la celda en la que esta.
                        aux.UrlImagen = (string)lector["Urlimagen"];

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
                dato.setearConsultaDB("insert into POKEMONS(Numero,Nombre,Descripcion,IdTipo,IdDebilidad, Activo, UrlImagen ) values (" + pokemonNuevo.Numero+ ",'"+pokemonNuevo.Nombre+"','"+pokemonNuevo.Descripcion+"',"+pokemonNuevo.Tipo.id+",@debilidad,1,@url)");
                dato.setearParametros("@debilidad",pokemonNuevo.Debilidad.id);
                dato.setearParametros("@url", pokemonNuevo.UrlImagen);
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
        public void modificar(Pokemon pokemonAmodificar)
        {
            AccesoDatos dato = new AccesoDatos();

            try
            {
                dato.setearConsultaDB("update POKEMONS set  Numero=@numero,Nombre=@nombre,Descripcion=@descripcion,IdTipo=@idTipo,IdDebilidad=@idDebilidad,UrlImagen=@url where Id= @id");
                dato.setearParametros("@id", pokemonAmodificar.Id);
                dato.setearParametros("@numero", pokemonAmodificar.Numero);
                dato.setearParametros("@nombre", pokemonAmodificar.Nombre);
                dato.setearParametros("@descripcion", pokemonAmodificar.Descripcion);
                dato.setearParametros("@idTipo", pokemonAmodificar.Tipo.id);
                dato.setearParametros("@idDebilidad", pokemonAmodificar.Debilidad.id);
                dato.setearParametros("@url", pokemonAmodificar.UrlImagen);

                dato.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
        public void eliminarFisico(int id)
        {
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.setearConsultaDB("delete POKEMONS where Id=@Id");
                dato.setearParametros("@Id",id);
                dato.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
        public void eliminarLogico(int id)
        {
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.setearConsultaDB("update POKEMONS set Activo=0 where Id=@id");
                dato.setearParametros("@id", id);
                dato.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dato.cerrarConexion();
            }
            


        }
        
    }
}
