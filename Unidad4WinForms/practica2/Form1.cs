using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lwListaElementos.Items.Add(txtNombre.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbColores.Items.Add("Verde");
            cmbColores.Items.Add("Rojo");
            cmbColores.Items.Add("Azul");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = "nombre: "+txtNombre.Text+ ",";
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate= ckbChocolate.Checked== true? "Le gusta el chocolate":"odia el chocolate";
            string tipoDePizza;
            if (rbtAnana.Checked)
                tipoDePizza = "Anana";
            else if (rbtFugazzeta.Checked)
                tipoDePizza = "Fugazzeta";
            else
                tipoDePizza = "napolitana";

            string color = cmbColores.Text;
            string numeroFavorito = nudNumeroFavorito.Value.ToString();
            MessageBox.Show(nombre+ "Fecha de nacimiento: "+ fecha + "," + chocolate+ ", " + "la pizza que le gusta es la " + tipoDePizza+
                ",su color favorito es el "+ color+ ", su numero favorito es "+numeroFavorito);
        }
    }
}
