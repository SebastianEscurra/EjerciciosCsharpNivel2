using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3winFormsConClases
{
    internal class AnalistaDeDatos: Persona
    {
        public float sueldo { get { return 1500f; } }
        public string profesion { get { return "Analista de datos"; } }


        public string analizarSistema()
        {
            return $"soy {nombre} y estoy analizando el sistema.";
        }
    }
}
