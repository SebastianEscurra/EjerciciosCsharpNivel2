using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Asociacion
{
    internal class Motor
    {
        private int potencia = 1500;

        private string nombre = "m1";
        public string _nombre { get { return nombre; } }

        public int Potencia { get => potencia; set => potencia = value; }
    }
}
