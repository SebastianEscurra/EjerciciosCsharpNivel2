using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Persona
    {
        // Atributos
        public Datos datos = new Datos();

        // Propiedades
        public Persona(string nombre,string ubicacion,string tel)
        {
            datos.nombre = nombre;
            datos.ubicacion = ubicacion;
            datos.telefono = tel;

        }
    }
}
