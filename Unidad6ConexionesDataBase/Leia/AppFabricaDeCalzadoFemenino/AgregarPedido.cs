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
            ProductoNegocio datoProducto = new ProductoNegocio();
            ClienteNegocio datoCliente = new ClienteNegocio();

            cbxTipoDeCalzado.DataSource = datoProducto.listar();
            cbxCliente.DataSource = datoCliente.listar();
            cbxEstado.Items.Add("Pendiente");
            cbxEstado.Items.Add("Entregado");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PedidoNegocio datoPedido = new PedidoNegocio();
            Pedido pedidoNuevo = new Pedido();
            ClienteNegocio datoCliente = new ClienteNegocio();
            Cliente clienteActual = new Cliente();
            ProductoNegocio datoProducto = new ProductoNegocio();
            Producto productoActual = new Producto();
            try
            {
                foreach (var item in datoCliente.listar())
            {
                if (item.nombre == cbxCliente.Text)
                    clienteActual = item;
            }
                foreach (var item in datoProducto.listar())
            {
                if (item.nombre == cbxTipoDeCalzado.Text)
                    productoActual = item;
            }
                            
                pedidoNuevo.cliente=clienteActual;
                pedidoNuevo.tipoDeCalzado=productoActual;
                pedidoNuevo.cantidad = int.Parse(tbxCantidad.Text);
                pedidoNuevo.fechaDePedido = DateTime.Parse(dtpFechaDePedido.Text);
                pedidoNuevo.fechaDeEntrega = DateTime.Parse(dtpFechaDeEntrega.Text);
                pedidoNuevo.estado = cbxEstado.Text;
                pedidoNuevo.presupuestoFinal = (pedidoNuevo.cantidad * pedidoNuevo.tipoDeCalzado.precio).ToString();
                datoPedido.agregar(pedidoNuevo);

                MessageBox.Show("Pedido cargado");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void tbxCantidad_TextChanged(object sender, EventArgs e)
        {
            //cargamos el resultado de cantidad * precio del producto seleccionado
            ProductoNegocio producto = new ProductoNegocio();
            foreach (var item in producto.listar())
            {
                if (item.nombre == cbxTipoDeCalzado.Text)
                    try
                    {
                    lblPresupuestoFinalDato.Text= (item.precio * int.Parse(tbxCantidad.Text)).ToString("C0", CultureInfo.GetCultureInfo("es-AR"));

                    }
                    catch (Exception)
                    {

                        lblPresupuestoFinalDato.Text="";
                    }

            }
        }

        private void cbxTipoDeCalzado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargamos el resultado de cantidad * precio del producto seleccionado
            ProductoNegocio producto = new ProductoNegocio();
            foreach (var item in producto.listar())
            {
                if (item.nombre == cbxTipoDeCalzado.Text)
                    try
                    {
                        lblPresupuestoFinalDato.Text = (item.precio * int.Parse(tbxCantidad.Text)).ToString("C0", CultureInfo.GetCultureInfo("es-AR"));

                    }
                    catch (Exception)
                    {

                        lblPresupuestoFinalDato.Text = "";
                    }

            }
        }
    }
}
