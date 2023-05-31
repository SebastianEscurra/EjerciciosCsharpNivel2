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

namespace conexionaDBejercicio2
{
    public partial class frmAgregarDisco : Form
    {
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco discoNuevo = new Disco();

            try
            {
                discoNuevo.titulo = tbxTitulo.Text;
                discoNuevo.cantidadDeCanciones = int.Parse(tbxCantidad.Text);
                discoNuevo.fechaDeLanzamiento = DateTime.Parse(tbxFecha.Text);
                discoNuevo.estilo = new Estilo();
                discoNuevo.estilo.id = int.Parse(tbxEstilo.Text);
            
                DiscoNegocio negocio = new DiscoNegocio();
                negocio.agregar(discoNuevo);
                MessageBox.Show("Disco Agregado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
