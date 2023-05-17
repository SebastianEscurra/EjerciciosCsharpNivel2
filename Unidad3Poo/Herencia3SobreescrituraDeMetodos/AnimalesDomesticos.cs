using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3SobreescrituraDeMetodos
{
    internal class AnimalesDomesticos: Animales
    {
        public string nombre;
        public override string ToString()
        {
            return "Animal domestico: " + nombre;
        }
    }
}
