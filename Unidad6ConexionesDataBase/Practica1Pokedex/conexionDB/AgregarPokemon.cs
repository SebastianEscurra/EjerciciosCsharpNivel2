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

namespace conexionDB
{
    public partial class frmAgregarPokemon : Form
    {
        private Pokemon pokemon = null;
        public frmAgregarPokemon()
        {
            InitializeComponent();
        }
        public frmAgregarPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();

            try
            {
                if (pokemon==null)
                    pokemon = new Pokemon();
                
                pokemon.Numero = int.Parse(tbxNumero.Text);
                pokemon.Nombre = tbxNombre.Text;
                pokemon.Descripcion = tbxDescripcion.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;
                pokemon.UrlImagen = tbxUrl.Text;

                if (pokemon.Id == 0)
                {
                    pokemonNegocio.agregar(pokemon);
                    MessageBox.Show("agregado exitosamente");
                }
                else
                {
                    pokemonNegocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void tbxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<48 || e.KeyChar>59) && e.KeyChar!=8)
                e.Handled = true;
        }

        private void tbxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar<49 || e.KeyChar>51) && e.KeyChar!=8)
                    e.Handled = true;
        }

        private void frmAgregarPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            
            cboTipo.DataSource = elementoNegocio.listar();
            cboTipo.ValueMember = "id";
            cboTipo.DisplayMember = "descripcion";
            cboDebilidad.DataSource = elementoNegocio.listar();
            cboDebilidad.ValueMember = "id";
            cboDebilidad.DisplayMember = "descripcion";

            if (pokemon != null)
            {
                tbxNumero.Text = pokemon.Numero.ToString();
                tbxNombre.Text = pokemon.Nombre;
                tbxDescripcion.Text = pokemon.Descripcion;
                tbxUrl.Text = pokemon.UrlImagen;
                mostraImagen(pokemon.UrlImagen);
                cboDebilidad.SelectedValue = pokemon.Debilidad.id;
                cboTipo.SelectedValue = pokemon.Tipo.id;
            }
                
        }

        private void tbxUrl_Leave(object sender, EventArgs e)
        {
            mostraImagen(tbxUrl.Text);
        }

        public void mostraImagen(string url)
        {
            try
            {
                pbxPokemon.Load(url);
            }
            catch (Exception)
            {

                pbxPokemon.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQKAz4Q_iTunY8wXCG123QkN8DDBr1Pl7xALVwdwE4wtGLjH2gWSbG9A4iK7MF6NOKnP4g&usqp=CAU");
            }
        }
    }
}
