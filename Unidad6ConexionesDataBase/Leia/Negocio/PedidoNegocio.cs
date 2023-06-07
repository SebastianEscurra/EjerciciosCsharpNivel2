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
    public class PedidoNegocio
    {
        
        public List<Pedido> listar()
        {
            List<Pedido> pedidos = new List<Pedido>();
            AccesoDatos dato=new AccesoDatos();

            try
            {
                dato.setearConsulta("select pe.Cantidad Cantidad,pr.Precio PrecioUnitario,pe.presupuestoFinal presupuestoFinal,pe.FechaPedido FechaPedido,pe.FechaLimiteEntrega FechaLimiteEntrega,pe.Estado Estado,pr.URLimagen URLimagen, c.Nombre NombreCliente,pr.Nombre TipoDeZapato from Cliente c,Producto pr,Pedidos pe where pe.Id_Cliente=c.Id and pe.Id_Producto=pr.Id");
                dato.ejecutarLectura();

                while (dato.Lector.Read())
                {
                    Pedido aux = new Pedido();
                    aux.cantidad = (int)dato.Lector["Cantidad"];
                    
                    aux.fechaDePedido = (DateTime)dato.Lector["FechaPedido"];
                    aux.fechaDeEntrega = (DateTime)dato.Lector["FechaLimiteEntrega"];
                    aux.cliente = new Cliente();
                    aux.cliente.nombre = (string)dato.Lector["NombreCliente"];
                    aux.tipoDeCalzado = new Producto();
                    aux.tipoDeCalzado.nombre = (string)dato.Lector["TipoDeZapato"];
                    aux.estado = (string)dato.Lector["Estado"];
                    aux.tipoDeCalzado.precio = (double)dato.Lector["PrecioUnitario"];
                    
                    aux.presupuestoFinal = (aux.cantidad * aux.tipoDeCalzado.precio).ToString("C0",CultureInfo.GetCultureInfo("es-AR"));
                    if (!(dato.Lector["URLimagen"] is DBNull))
                        aux.tipoDeCalzado.UrlImagen = (string)dato.Lector["URLimagen"];

                 
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
        public void agregar(Pedido pedido)
        {
            //
            //AL NO TENER CONFIGURADA LA DB DE LA COLUMNA ID CON UN VALOR AUTOMATICO LE ENVIAMOS
            //UN NUMERO ALEATORIO
            //
            Random random = new Random();
            int numeroAleatorio = random.Next(100, 999); 
            //
            //REVISAR COMO CAMBIARLO
            //
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Pedidos(Id,Cantidad,PresupuestoFinal,FechaPedido,FechaLimiteEntrega,Estado,Id_Cliente,Id_Producto) values (@Id,@Cantidad,@PresupuestoFinal,@FechaPedido,@FechaEntrega,@Estado,@IdCliente,@IdProducto)");
                datos.setearParametros("@Id",numeroAleatorio);
                datos.setearParametros("@Cantidad", pedido.cantidad);
                datos.setearParametros("@PresupuestoFinal", pedido.presupuestoFinal);
                datos.setearParametros("@FechaPedido", pedido.fechaDePedido);
                datos.setearParametros("@FechaEntrega", pedido.fechaDeEntrega);
                datos.setearParametros("@Estado", pedido.estado);
                datos.setearParametros("@IdCliente", pedido.cliente.id);
                datos.setearParametros("@IdProducto", pedido.tipoDeCalzado.id);
                datos.ejecutarAccion();
                
                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
    }
}
