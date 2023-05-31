using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {
			List<Elemento> listaElementos = new List<Elemento>();
			AccesoDatos dato = new AccesoDatos();
			

			try
			{
				dato.setearConsultaDB("select Id,Descripcion from ELEMENTOS");
				dato.ejecutarLectura();

				while (dato._lector.Read())
				{
					Elemento aux = new Elemento();
					aux.id = (int)dato._lector["Id"];
					aux.descripcion = (string)dato._lector["Descripcion"];
					listaElementos.Add(aux);
				}

				return listaElementos;
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
