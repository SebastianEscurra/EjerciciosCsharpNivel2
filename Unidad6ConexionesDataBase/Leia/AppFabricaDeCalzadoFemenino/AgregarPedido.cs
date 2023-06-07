using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFabricaDeCalzadoFemenino
{
    public partial class frmAgregarPedido : Form
    {
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private ClienteNegocio clienteNegocio = new ClienteNegocio();
        private PedidoNegocio pedidoNegocio = new PedidoNegocio();

        public frmAgregarPedido()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarPedido_Load(object sender, EventArgs e)
        {
            cbxTipoDeCalzado.DataSource = productoNegocio.listar();
            cbxCliente.DataSource = clienteNegocio.listar();
            cbxEstado.Items.Add("Pendiente");
            cbxEstado.Items.Add("Entregado");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pedido pedidoNuevo = new Pedido();
            Cliente clienteActual = obtenerElementoActual(clienteNegocio);
            Producto productoActual = obtenerElementoActual(productoNegocio);
            try
            {                          
                pedidoNuevo.cliente=clienteActual;
                pedidoNuevo.tipoDeCalzado=productoActual;
                pedidoNuevo.cantidad = int.Parse(tbxCantidad.Text);
                pedidoNuevo.fechaDePedido = DateTime.Parse(dtpFechaDePedido.Text);
                pedidoNuevo.fechaDeEntrega = DateTime.Parse(dtpFechaDeEntrega.Text);
                pedidoNuevo.estado = cbxEstado.Text;
                pedidoNuevo.presupuestoFinal = (pedidoNuevo.cantidad * pedidoNuevo.tipoDeCalzado.precio).ToString();
                pedidoNegocio.agregar(pedidoNuevo);

                MessageBox.Show("Pedido cargado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        
        private void tbxCantidad_TextChanged(object sender, EventArgs e) 
        {
            //cargamos el PRESUPUESTO FINAL teniendo de referencia la cantidad que ingresa

            Producto productoActual = obtenerElementoActual(productoNegocio);

                    try
                    {
                        lblPresupuestoFinalDato.Text= (productoActual.precio * int.Parse(tbxCantidad.Text)).ToString("C0", CultureInfo.GetCultureInfo("es-AR"));
                    }
                    catch (Exception)
                    {
                        lblPresupuestoFinalDato.Text=""; // si el usuario vacia tbxcantidad muestra el label vacio
                    }
        }

        private void cbxTipoDeCalzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargamos el PRESUPUESTO FINAL teniendo de referencia el calzado que selecciona
            Producto productoActual = obtenerElementoActual(productoNegocio);
            
                    try
                    {
                        lblPresupuestoFinalDato.Text = (productoActual.precio * int.Parse(tbxCantidad.Text)).ToString("C0", CultureInfo.GetCultureInfo("es-AR"));
                    }
                    catch (Exception)
                    {
                        lblPresupuestoFinalDato.Text = ""; // si el usuario no seleccciono un calzado muestra el label vacio
                    }
        }
        private Producto obtenerElementoActual(ProductoNegocio productoNegocio)
        {
            Producto productoActual = new Producto();
            foreach (var item in productoNegocio.listar())
            {
                if (item.nombre == cbxTipoDeCalzado.Text)
                    productoActual = item;
            }
            return productoActual;
        }
        private Cliente obtenerElementoActual(ClienteNegocio clienteNegocio)
        {
            Cliente clienteActual = new Cliente();
            foreach (var item in clienteNegocio.listar())
            {
                if (item.nombre == cbxCliente.Text)
                    clienteActual = item;
            }
            return clienteActual;
        }
    }
}
