using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppFabricaDeCalzadoFemenino
{
    internal class PedidoDato
    {
        public List<Pedido> listar()
        {
            List<Pedido> pedidos = new List<Pedido>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLexpress;database=FABRICA_ZAPATOS_DB;integrated security=true;";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select pe.Cantidad Cantidad,pr.Precio PrecioUnitario,pe.Precio Precio,pe.FechaPedido FechaPedido,pe.FechaLimiteEntrega FechaLimiteEntrega,pe.Estado Estado,pr.URLimagen URLimagen, c.Nombre NombreCliente,pr.Nombre TipoDeZapato from Cliente c,Producto pr,Pedidos pe where pe.Id_Cliente=c.Id and pe.Id_Producto=pr.Id";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pedido aux = new Pedido();
                    aux.cantidad = (int)lector["Cantidad"];
                    aux.presupuesto = (double)lector["Precio"];
                    aux.fechaDePedido = (DateTime)lector["FechaPedido"];
                    aux.fechaDeEntrega = (DateTime)lector["FechaLimiteEntrega"];
                    aux.cliente = new Cliente();
                    aux.cliente.nombre = (string)lector["NombreCliente"];
                    aux.tipoDeCalzado = new Producto();
                    aux.tipoDeCalzado.nombre = (string)lector["TipoDeZapato"];
                    aux.estado = (string)lector["Estado"];
                    aux.tipoDeCalzado.precio = (double)lector["PrecioUnitario"];
                    aux.presupuesto = aux.cantidad * aux.tipoDeCalzado.precio;
                    aux.tipoDeCalzado.UrlImagen = (string)lector["URLimagen"];

                 
                    pedidos.Add(aux);
                }
              
                return pedidos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            
        }
    }
}
