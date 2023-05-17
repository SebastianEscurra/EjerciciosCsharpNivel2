using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class frmFormulario1 : Form
    {
        public frmFormulario1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenidos a c#");
        }

        private void FrmPrincioal_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("adios");
        }

        private void btnApretar_Click(object sender, EventArgs e) //probe usar randon para cargar colores distintos cada vez
        {
            contador = 0;
            /*  MessageBox.Show("Se disparo el evento Click", "Atención");
              Random num1 = new Random();

              this.BackColor = Color.FromArgb(255, num1.Next(0, 99), num1.Next(99,155), num1.Next(0, 255));
              btnApretar.BackColor = Color.FromArgb(255, 52, 21, 59);

              MouseEventArgs clic = (MouseEventArgs)e;// identificamos que boton hace clic

              if (clic.Button == MouseButtons.Left)
                  MessageBox.Show("se apreto el boton izquierdo");
              else if (clic.Button == MouseButtons.Right)
                  MessageBox.Show("se apreto el boton derecho");
              else
                  MessageBox.Show("se apreto otro boton");*/
            if (txbPrueba.Text == "")
            {
                txbPrueba.BackColor = Color.Red;

            }
            else
                txbPrueba.BackColor = SystemColors.Control;

        }

        private void lblFormularioCambiate_MouseMove(object sender, MouseEventArgs e)
        {
            lblFormularioCambiate.ForeColor = Color.DeepPink;
            lblFormularioCambiate.BackColor = Color.DarkGoldenrod;
            lblFormularioCambiate.Cursor = Cursors.Hand;
        }

        private void lblFormularioCambiate_MouseLeave(object sender, EventArgs e)
        {
            lblFormularioCambiate.ForeColor = SystemColors.Control;
            lblFormularioCambiate.BackColor = Color.CornflowerBlue;
            lblFormularioCambiate.Cursor = Cursors.Arrow;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            txbCambiante.ForeColor = Color.IndianRed;
        }
        public int contador = 0;
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                txbCambiante.Text = "todo bien y vos?";
                txbCambiante.ForeColor = Color.LightBlue;
                contador ++;
            }else if (contador == 1)
            {
                txbCambiante.Text = "ahora me encuentro pensado en soluciones a unos problemas de programacion";
                txbCambiante.ForeColor = Color.DarkCyan;
                contador++;
            }
            
        }

        private void txbPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txbContarCaracteres_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("el numero de caracteres utilizados es: " + txbContarCaracteres.TextLength);
        }
    }
}
