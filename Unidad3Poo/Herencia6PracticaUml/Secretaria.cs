using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Secretaria: Espacios
    {
        // Atributos
        private List<Auxiliar> listAuxiliares=new List<Auxiliar>();
        private List<Docente> listDocentes=new List<Docente>();
        private List<Directivo> listDirectivos=new List<Directivo>();
        private List<Alumno> listAlumnos = new List<Alumno>();

        // Propiedades
        public List<Auxiliar> _listaAuxiliares { get {return listAuxiliares; } set {listAuxiliares=value; } }
        public List<Docente> _listDocentes { get { return listDocentes; }set { listDocentes= value; } }
        public List <Directivo> _listDirectivos { get { return listDirectivos; } set { listDirectivos = value; } }
        public List<Alumno> _listAlumnos { get { return listAlumnos; }  set {listAlumnos=value; } }

        // Metodos
        public string pasarLicencia()
        {
            return "aprobamos su licencia";
        }
    }
}
