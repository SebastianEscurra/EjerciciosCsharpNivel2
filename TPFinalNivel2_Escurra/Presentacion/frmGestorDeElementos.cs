using Domino2;
using Negocio2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Presentacion
{
    public partial class frmGestorDeElementos : Form
    {
        //Atributos
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;

        //Constructores
        public frmGestorDeElementos()
        {
            InitializeComponent();
            
        }
        public frmGestorDeElementos(Articulo articuloSeleccionado)
        {
            InitializeComponent();
            
            articulo = articuloSeleccionado;
        }

        //Eventos
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

        private void btnAgregarImagenLocal_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;| png|*.png";
            archivo.ShowDialog();
            Helper.cargarImagen(pbxArticulo, archivo.FileName);
            txtUrl.Text = archivo.FileName;
            
        }

        private void txtUrl_Leave(object sender, EventArgs e)
        {
            Helper.cargarImagen(pbxArticulo, txtUrl.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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
                copiarImagenAcarpetaLocal(ref articulo);
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

        //Metodos
        private void copiarImagenAcarpetaLocal(ref Articulo articulo)
        {
            //
            //Sise toco el btn para agregar imagen y si no se modifico el txturl
            //
            if (archivo != null && txtUrl.Text == archivo.FileName)
            {
                string direccion = ConfigurationManager.AppSettings["gestionArticulos-app"];
                string nombreImagen = archivo.SafeFileName;
                //
                //Actualizamos la url de la base de datos
                //
                articulo.UrlImagen = direccion + nombreImagen;
                //
                //Copiamos a carpeta local
                //
                File.Copy(archivo.FileName, direccion + nombreImagen);
            }
        }

    }
}
