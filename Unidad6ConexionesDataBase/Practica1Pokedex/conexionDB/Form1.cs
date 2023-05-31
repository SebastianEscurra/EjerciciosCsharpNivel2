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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio pokemons = new PokemonNegocio();
            dgvPokedex.DataSource = pokemons.obtenerListaPokemon();
            dgvPokedex.Columns["urlImagen"].Visible = false;
            mostrarImagen("https://www.gamespot.com/a/uploads/scale_medium/1601/16018044/3968710-pokedex-run.jpg");
            
        }

        private void dgvPokedex_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon pokemonActual = (Pokemon)dgvPokedex.CurrentRow.DataBoundItem;
            mostrarImagen(pokemonActual.urlImagen);
        }

        public void mostrarImagen(string url)
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

        private void btnAgregarPokemon_Click(object sender, EventArgs e)
        {
            frmAgregarPokemon ventanaAgregarPokemon = new frmAgregarPokemon();
            ventanaAgregarPokemon.ShowDialog();
        }
    }
}
