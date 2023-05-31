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
    public partial class Form1 : Form
    {
        private List<Disco> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoNegocio listado = new DiscoNegocio();

            listaDiscos = listado.listar();
            dgvListaDiscos.DataSource = listaDiscos;
            dgvListaDiscos.Columns["UrlImagen"].Visible = false;
            pbxDiscos.Load("https://img.freepik.com/vector-gratis/tocadiscos-vinilo_1284-52273.jpg");
        }

       
        private void cargarImagen(string imagen)
        {

            try
            {
                pbxDiscos.Load(imagen);

            }
            catch (Exception)
            {

                pbxDiscos.Load("https://img.freepik.com/iconos-gratis/imagen_318-150777.jpg");
            }
        }

        private void dgvListaDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco discoSeleccionado = (Disco) dgvListaDiscos.CurrentRow.DataBoundItem;
            cargarImagen(discoSeleccionado.UrlImagen);

        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            frmAgregarDisco nuevaVentana = new frmAgregarDisco();
            nuevaVentana.ShowDialog();
        }
    }
}
