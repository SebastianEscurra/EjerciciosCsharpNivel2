﻿using System;
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
            cargarGrilla();
        }
        private void cargarGrilla()
        {
            PokemonNegocio pokemons = new PokemonNegocio();
            dgvPokedex.DataSource = pokemons.listar();
            dgvPokedex.Columns["urlImagen"].Visible = false;
            dgvPokedex.Columns["Id"].Visible=false;
            mostrarImagen("https://www.gamespot.com/a/uploads/scale_medium/1601/16018044/3968710-pokedex-run.jpg");
        }
        private void dgvPokedex_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon pokemonActual = (Pokemon)dgvPokedex.CurrentRow.DataBoundItem;
            mostrarImagen(pokemonActual.UrlImagen);
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
            ventanaAgregarPokemon.ShowDialog();// detiene la lectura lineal, continua cuando cierra
            cargarGrilla(); //actualiza lista
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokedex.CurrentRow.DataBoundItem;
            frmAgregarPokemon ventanaModificar = new frmAgregarPokemon(seleccionado);
            ventanaModificar.Text = "modificar pokemon";
            ventanaModificar.ShowDialog();
            cargarGrilla();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            Pokemon pokemonActual; 
            try
            {
                pokemonActual = (Pokemon)dgvPokedex.CurrentRow.DataBoundItem;
                DialogResult devuelve= MessageBox.Show("¿Eliminar pokemon?", "Eliminando",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (devuelve == DialogResult.Yes)
                {
                pokemonNegocio.borrar(pokemonActual.Id);
                cargarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
