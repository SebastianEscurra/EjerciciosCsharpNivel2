using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Aula: Espacios
    {
        // Atributos
        private List <Alumno> alumnosSeccion=new List<Alumno>();
        
        // Propiedades
        public List <Alumno> _alumnosSeccion { get { return alumnosSeccion; } set { alumnosSeccion = value; } }
        public string seccion { get; set; }


        
    }
}
