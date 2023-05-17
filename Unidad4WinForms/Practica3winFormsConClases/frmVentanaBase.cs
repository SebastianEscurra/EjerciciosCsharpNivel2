using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3winFormsConClases
{
    public partial class frmVentanaBase : Form
    {
        public frmVentanaBase()
        {
            InitializeComponent();
        }

        private void sueldoYProfesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof (frmSueldosYprofesiones))
                    return;
            }
            frmSueldosYprofesiones sueldosYprofesiones= new frmSueldosYprofesiones();
            sueldosYprofesiones.MdiParent = this;
            sueldosYprofesiones.Show();
        }

        private void queEsWinformsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Winforms es un formulario / ventana que nos permite diseñar," +
                "\na travez de herramientas, una interfas grafica\npara que el usuario pueda manejar el programa. ");
        }

        private void queEsUnEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un evento es un metodo que se da en un contexto determinado." +
                "\nEjemplo: tenemos una ventana que tiene un boton y si nosotro lo presionamos hace algo.\n" +
                "-La accion de presionar un boton va a ser el evento que nos permitira mostrar ese algo.\n" +
                "-Debemos definir que sera lo que se muestra dentro de ese evento: pede ser un messagebox.");
        }

        private void operadorTernarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un operador ternario es una herramienta condicional como el if,\n" +
                "pero a diferencia de este el operador ternario resuelve la condicion en una linea\n" +
                "-Tener en cuenta que este se usa con expresiones booleanas y que devuelve un string para el verdadero y otro para el falso\n" +
                "-Se escribe asi: *** condicion ? mensaje si es verdadero : mensaje si es falso;");
        }

        private void comoNavegarEntreVentanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1- Crear un nuevo formulario\n" +
                "2- en el main definir a que formulario se debe dirigir para abrirlo como ventana principal.\n" +
                "3-Elegimos una de la herramientas que tenemos disponible (botones,barra de herramientas) para que nos dirija a la ventana\n" +
                "a travez de un evento\n3-detro del evento creamos un objeto de la ventana a la cual quremos dirigirnos" +
                "\n4-Colocamos el nombre de la ventana. Show()");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmSueldosYprofesiones frmSueldosYprofesiones = new frmSueldosYprofesiones();
            frmSueldosYprofesiones.ShowDialog();
        }
    }
}
