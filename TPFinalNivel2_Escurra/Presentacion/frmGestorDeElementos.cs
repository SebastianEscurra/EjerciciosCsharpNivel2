using Domino2;
using Negocio2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmGestorDeElementos : Form
    {
        
        Articulo articulo = null;
        
        public frmGestorDeElementos()
        {
            InitializeComponent();
            
        }
        public frmGestorDeElementos(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            
            articulo = articuloSeleccionado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmGestorDeElementos_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            cmbMarca.DataSource = marcaNegocio.listar();
            cmbMarca.ValueMember = "id";
            cmbMarca.DisplayMember = "descripcion";
            cmbCategoria.DataSource = categoriaNegocio.listar();
            cmbCategoria.ValueMember = "id";
            cmbCategoria.DisplayMember = "descripcion";
            cmbMarca.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;

            if (articulo != null)
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtUrl.Text = articulo.UrlImagen;
                txtPrecio.Text = articulo.Precio.ToString();
                cmbMarca.SelectedValue = articulo.Marca.Id;
                cmbCategoria.SelectedValue=articulo.Categoria.Id;
                Helper.cargarImagen(pbxArticulo, articulo.UrlImagen);

            }
            
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (articulo == null)
                articulo = new Articulo();

            try
            {
                
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca =(Marca)cmbMarca.SelectedItem;
                articulo.Categoria =(Categoria)cmbCategoria.SelectedItem;
                articulo.UrlImagen = txtUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id == 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Articulo agregado.");
                }
                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Articulo modificado.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(pbxArticulo, txtUrl.Text);
        }
    }
}
