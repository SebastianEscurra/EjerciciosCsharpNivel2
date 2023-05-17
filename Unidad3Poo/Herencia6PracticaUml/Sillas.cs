using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    
    internal class Sillas
    {

        //atributos
        private string estado = "bueno";
        private int altura = 5;
        private int ancho = 3;

        //propiedades
        public int _altura { get { return altura; } }
        public int _ancho { get { return ancho; } }
        public string _estado{ get { return estado; }}

        //metodos
        public void romper()
        {
            estado = "roto";
        }

        public void arreglar()
        {
            estado = "bueno";
        }

    }

    
}
