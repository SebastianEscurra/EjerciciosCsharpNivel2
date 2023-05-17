using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Asociacion
{
    internal class Carroceria
    {
        private int largo=55;
        private int ancho=33;
        private int alto=22;
        private string nombre="carroceria auto de carreras";


        public int Ancho { get => ancho; set => ancho = value; }
        public int Alto { get => alto; set => alto = value; }
        public int Largo { get => largo; set => largo = value; }
        public string Nombre { get => nombre; }
    }
}
