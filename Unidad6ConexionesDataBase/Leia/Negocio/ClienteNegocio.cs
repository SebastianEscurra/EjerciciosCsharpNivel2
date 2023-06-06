using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public List<Cliente> listar()
        {
			AccesoDatos dato = new AccesoDatos();
			List<Cliente> clientes = new List<Cliente>();

			try
			{
				dato.setearConsulta("select Id,Nombre,NumeroTelefono,Email from Cliente");
				dato.ejecutarLectura();

				while (dato.Lector.Read())
				{
					Cliente aux = new Cliente();

					aux.id = (int)dato.Lector["Id"];
					aux.nombre = (string)dato.Lector["Nombre"];
					aux.numeroDeTelefono = (int)dato.Lector["NumeroTelefono"];
					aux.email = (string)dato.Lector["Email"];

					clientes.Add(aux);
				}



				return clientes;
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
