using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace AppFabricaDeCalzadoFemenino
{
    public partial class Form1 : Form
    {
        private List<Pedido> pedidos;
        private PedidoNegocio pedidoNegocio = new PedidoNegocio();
        private Pedido pedidoActual = new Pedido();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void dgvListaPedidos_SelectionChanged(object sender, EventArgs e)
        {
            pedidoActual = (Pedido)dgvListaPedidos.CurrentRow.DataBoundItem;
            mostrarImagen(pedidoActual.tipoDeCalzado.UrlImagen);
        }

        public void mostrarImagen(string url)
        {
            try
            {
            pbxImagenCalzados.Load(url);
            }
            catch (Exception)
            {
                pbxImagenCalzados.Load("https://cdn-icons-png.flaticon.com/512/85/85488.png");
            }
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            frmAgregarPedido ventanaAgregar = new frmAgregarPedido();
            ventanaAgregar.ShowDialog(); // detiene la ejecucion
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            pedidos = pedidoNegocio.listar(); //obtiene la lista de pedidos
            dgvListaPedidos.DataSource = pedidos; //cargamos la lista a la grilla
            dgvListaPedidos.Columns[0].Visible = false; // ocultamos columnas id y descripcion
            dgvListaPedidos.Columns[3].Visible = false;
            pintarFilasSegunEstado();
        }
        private void pintarFilasSegunEstado()
        {
            for (int i = 0; i < dgvListaPedidos.RowCount; i++)
            {
                if (dgvListaPedidos.Rows[i].Cells[8].Value.ToString() == "Entregado")
                {
                    dgvListaPedidos.Rows[i].DefaultCellStyle.BackColor = Color.GreenYellow;
                }
            }
        }
    }
}
