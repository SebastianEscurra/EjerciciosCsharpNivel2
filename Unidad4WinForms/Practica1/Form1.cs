using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnBotonMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string nacionalidad = txtNacionalidad.Text;
            string fNacimiento=txtFechaNacimiento.Text;
            int añoDeNacimiento = Int32.Parse(fNacimiento.Substring(6));
            

            int edad = 2023 - añoDeNacimiento;

            lblMostrarInfo.Text = "Nombre: " + nombre + "\nEdad: " + edad +
                "\nFecha de nacimiento: " + fNacimiento + "\nNacionalidad: " + nacionalidad +
                "\nNivel de estudios: " + txtNivel.Text + "\nEstablecimiento: " + txtEstablecimiento.Text;
            

        }

        private void txtFechaNacimiento_TextChanged(object sender, EventArgs e)
        {
            lblRecomendacionFormatoFecha.Text = "Ej: 15/01/1900";
        }
    }
}
