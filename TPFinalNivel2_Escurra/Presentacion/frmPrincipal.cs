using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio2;
using Domino2;


namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        private ArticuloNegocio articuloNegocio;
        private List<Articulo> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
            articuloNegocio = new ArticuloNegocio();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmFiltroAvanzado filtroAvanzado = new frmFiltroAvanzado();
            filtroAvanzado.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmGestorDeElementos agregar = new frmGestorDeElementos();
            agregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmGestorDeElementos modificar = new frmGestorDeElementos();
            modificar.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Urlimagen"].Visible = false;

        }
    }
}
