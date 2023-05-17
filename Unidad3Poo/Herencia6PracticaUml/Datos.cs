using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Datos
    {
        // Propiedades

        public string nombre { get { return "nombre: " + this.nombre; } set { this.nombre = value; }}
        public string ubicacion { get { return $"Ubicacion: {this.ubicacion}"; } set { this.ubicacion = value; } }
        public string telefono { get { return $"Telefono: {this.telefono}"; }set { this.telefono = value; } }
    }
}
