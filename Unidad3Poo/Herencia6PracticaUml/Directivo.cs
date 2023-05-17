using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Directivo : Persona
    {
        // Propiedades
        public Directivo(string nombre, string ubicacion, string tel) : base(nombre, ubicacion, tel)
        {

        }
        // Metodo

        public string gestionarEscuela()
        {
            return $"soy {base.datos.nombre} y estoy gestionando la escuela";
        }

        public string amonestar()
        {
            return "sancionado";
        }
    }
}
