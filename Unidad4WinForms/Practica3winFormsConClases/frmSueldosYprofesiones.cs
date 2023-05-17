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
    public partial class frmSueldosYprofesiones : Form
    {
        public frmSueldosYprofesiones()
        {
            InitializeComponent();
        }
        
        List<IngenieroDeSoftware> listaingenieros=new List<IngenieroDeSoftware>();
        List<AnalistaDeDatos> listaAnalistas = new List<AnalistaDeDatos>();
        
        
        int x = 0;
        int y = 0;

        private void btnCargarPersona_Click(object sender, EventArgs e)
        {
            if (rbtnIngenieroDeSoftware.Checked)
            {
                listaingenieros.Add(new IngenieroDeSoftware());
                listaingenieros[x].nombre = txtbNombre.Text;
                listaingenieros[x].edad = int.Parse(txtbEdad.Text);
                listaingenieros[x].numeroDeDocumento = int.Parse(txtbDocumento.Text);
                listaingenieros[x].direccion = txtbDireccion.Text;
                listaingenieros[x].localidad = txtbLocalidad.Text;
                listaingenieros[x].fechaNacimiento = dtpFechaNacimiento.Value;
                

                cbxSeleccionPersonal.Items.Add(listaingenieros[x].nombre);
                x++;
            }
            else
            {
                listaAnalistas.Add(new AnalistaDeDatos());
                listaAnalistas[y].nombre = txtbNombre.Text;
                listaAnalistas[y].edad = int.Parse(txtbEdad.Text);
                listaAnalistas[y].numeroDeDocumento = int.Parse(txtbDocumento.Text);
                listaAnalistas[y].direccion = txtbDireccion.Text;
                listaAnalistas[y].localidad = txtbLocalidad.Text;
                listaAnalistas[y].fechaNacimiento = dtpFechaNacimiento.Value;

                cbxSeleccionPersonal.Items.Add(listaAnalistas[y].nombre);
                y++;
            }
            MessageBox.Show("Analistas cargados: " + y + "\nIngenieros cargados: " + x);



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxMostrarDato.Items.Add("Nombre");
            cbxMostrarDato.Items.Add("Edad");
            cbxMostrarDato.Items.Add("Documento");
            cbxMostrarDato.Items.Add("Direccion");
            cbxMostrarDato.Items.Add("Localidad");
            cbxMostrarDato.Items.Add("Fecha de nacimiento");
            cbxMostrarDato.Items.Add("Profesion");
            cbxMostrarDato.Items.Add("Sueldo");
            cbxMostrarDato.Items.Add("TODOS LOS DATOS");
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
           
                foreach (var item in listaingenieros)
                {
                    if (cbxSeleccionPersonal.Text == item.nombre)
                    {
                    if (cbxMostrarDato.Text == "Nombre")
                        lvwListaDatos.Items.Add(item.nombre);
                    else if (cbxMostrarDato.Text == "Edad")
                    {
                        lvwListaDatos.Items.Add(item.edad.ToString());
                    }
                    else if (cbxMostrarDato.Text == "Documento")
                        lvwListaDatos.Items.Add(item.numeroDeDocumento.ToString());
                    else if (cbxMostrarDato.Text == "Direccion")
                        lvwListaDatos.Items.Add(item.direccion);
                    else if (cbxMostrarDato.Text == "Localidad")
                        lvwListaDatos.Items.Add(item.localidad);
                    else if (cbxMostrarDato.Text == "Fecha de nacimiento")
                        lvwListaDatos.Items.Add(item.fechaNacimiento.ToString());
                    else if (cbxMostrarDato.Text == "Profesion")
                        lvwListaDatos.Items.Add(item.profesion);
                    else if (cbxMostrarDato.Text == "Sueldo")
                        lvwListaDatos.Items.Add(item.sueldo.ToString());
                    else
                    {
                        lvwListaDatos.Items.Add(item.nombre);
                        lvwListaDatos.Items.Add(item.edad.ToString());
                        lvwListaDatos.Items.Add(item.numeroDeDocumento.ToString());
                        lvwListaDatos.Items.Add(item.direccion);
                        lvwListaDatos.Items.Add(item.localidad);
                        lvwListaDatos.Items.Add(item.fechaNacimiento.ToString());
                        lvwListaDatos.Items.Add(item.profesion);
                        lvwListaDatos.Items.Add(item.sueldo.ToString());
                    }

                    }
                }
           
            
                foreach (var item in listaAnalistas)
                {
                    if (cbxSeleccionPersonal.Text == item.nombre)
                    {
                        if (cbxMostrarDato.Text == "Nombre")
                            lvwListaDatos.Items.Add(item.nombre);
                        else if (cbxMostrarDato.Text == "Edad")
                            lvwListaDatos.Items.Add(item.edad.ToString());
                        else if (cbxMostrarDato.Text == "Documento")
                            lvwListaDatos.Items.Add(item.numeroDeDocumento.ToString());
                        else if (cbxMostrarDato.Text == "Direccion")
                            lvwListaDatos.Items.Add(item.direccion);
                        else if (cbxMostrarDato.Text == "Localidad")
                            lvwListaDatos.Items.Add(item.localidad);
                        else if (cbxMostrarDato.Text == "Fecha de nacimiento")
                            lvwListaDatos.Items.Add(item.fechaNacimiento.ToString());
                        else if (cbxMostrarDato.Text == "Profesion")
                            lvwListaDatos.Items.Add(item.profesion);
                        else if (cbxMostrarDato.Text == "Sueldo")
                            lvwListaDatos.Items.Add(item.sueldo.ToString());
                        else
                        {
                            lvwListaDatos.Items.Add(item.nombre);
                            lvwListaDatos.Items.Add(item.edad.ToString());
                            lvwListaDatos.Items.Add(item.numeroDeDocumento.ToString());
                            lvwListaDatos.Items.Add(item.direccion);
                            lvwListaDatos.Items.Add(item.localidad);
                            lvwListaDatos.Items.Add(item.fechaNacimiento.ToString());
                            lvwListaDatos.Items.Add(item.profesion);
                            lvwListaDatos.Items.Add(item.sueldo.ToString());
                        }

                    }
                }
            
        }
    }
}
