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
    public partial class frmAgregarPokemon : Form
    {
        public frmAgregarPokemon()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon pokemonnuevo = new Pokemon();
            try
            {
                pokemonnuevo.numero = int.Parse(tbxNumero.Text);
                pokemonnuevo.nombre = tbxNombre.Text;
                pokemonnuevo.descripcion = tbxDescripcion.Text;
                pokemonnuevo.tipo = (Elemento)cboTipo.SelectedItem;
                pokemonnuevo.debilidad = (Elemento)cboDebilidad.SelectedItem; 
               
                
                
                PokemonNegocio pokemonDato = new PokemonNegocio();
                pokemonDato.agregar(pokemonnuevo);
                MessageBox.Show("agregado exitosamente");



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
            ElementoNegocio negocio = new ElementoNegocio();
            
            cboTipo.DataSource = negocio.listar();
            cboDebilidad.DataSource = negocio.listar();
        }
    }
}