using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using Dominio;

namespace Negocio
{
    public class PedidoDato
    {
        public List<Pedido> listar()
        {
            List<Pedido> pedidos = new List<Pedido>();
            AccesoDatos dato=new AccesoDatos();

            try
            {
                dato.setearConsulta("select pe.Cantidad Cantidad,pr.Precio PrecioUnitario,pe.Precio Precio,pe.FechaPedido FechaPedido,pe.FechaLimiteEntrega FechaLimiteEntrega,pe.Estado Estado,pr.URLimagen URLimagen, c.Nombre NombreCliente,pr.Nombre TipoDeZapato from Cliente c,Producto pr,Pedidos pe where pe.Id_Cliente=c.Id and pe.Id_Producto=pr.Id");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Pedido aux = new Pedido();
                    aux.cantidad = (int)dato.Lector["Cantidad"];
                    aux.presupuesto = (double)dato.Lector["Precio"];
                    aux.fechaDePedido = (DateTime)dato.Lector["FechaPedido"];
                    aux.fechaDeEntrega = (DateTime)dato.Lector["FechaLimiteEntrega"];
                    aux.cliente = new Cliente();
                    aux.cliente.nombre = (string)dato.Lector["NombreCliente"];
                    aux.tipoDeCalzado = new Producto();
                    aux.tipoDeCalzado.nombre = (string)dato.Lector["TipoDeZapato"];
                    aux.estado = (string)dato.Lector["Estado"];
                    aux.tipoDeCalzado.precio = (double)dato.Lector["PrecioUnitario"];
                    aux.presupuesto = aux.cantidad * aux.tipoDeCalzado.precio;
                    aux.tipoDeCalzado.UrlImagen = (string)dato.Lector["URLimagen"];
                    aux.presupuestoFinal = aux.presupuesto.ToString("C0",CultureInfo.GetCultureInfo("es-AR"));

                 
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
                dato.cerrarConexion();
            }
            
        }
    }
}
