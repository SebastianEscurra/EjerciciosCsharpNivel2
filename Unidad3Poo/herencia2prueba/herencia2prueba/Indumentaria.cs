using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2prueba
{
    internal class Indumentaria
    {
        public string tela { get; set; }
        public override string ToString()
        {
            return "la tela de esta indumentaria es: " + tela;
        }
    }
}
