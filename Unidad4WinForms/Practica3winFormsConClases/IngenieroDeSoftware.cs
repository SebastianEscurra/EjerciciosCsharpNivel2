using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3winFormsConClases
{
    internal class IngenieroDeSoftware : Persona
    {
        public float sueldo { get { return 3000f; } }
        public string profesion { get { return "Ingeniero de software"; } }

        public string armarProyecto()
        {
            return $"soy {nombre} y estoy armando el proyecto.";
        }

    }
}
