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
                Estilo estiloActual = new Estilo();
                EstiloNegocio datoEstilo = new EstiloNegocio();

                foreach (var item in datoEstilo.listar())
                {
                    if (item.descripcion == cmbEstilo.Text)
                        estiloActual = item;
                }
                
                discoNuevo.titulo = tbxTitulo.Text;
                discoNuevo.cantidadDeCanciones = int.Parse(tbxCantidad.Text);
                discoNuevo.fechaDeLanzamiento = dtpFechaLanzamiento.Value.Date;
                discoNuevo.estilo = estiloActual;
                discoNuevo.UrlImagen = tbxUrl.Text;
               
            
                DiscoNegocio negocio = new DiscoNegocio();
                negocio.agregar(discoNuevo);
                MessageBox.Show("Disco Agregado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio datoEstilo = new EstiloNegocio();
            cmbEstilo.DataSource = datoEstilo.listar();
        }

        private void tbxUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrl.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxDisco.Load(imagen);
            }
            catch (Exception)
            {
                pbxDisco.Load("https://img.freepik.com/iconos-gratis/imagen_318-150777.jpg");
            }
        }
    }
}
