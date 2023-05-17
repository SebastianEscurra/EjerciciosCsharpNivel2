using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaIntegradora
{
    internal class Empresa
    {
        public string nombre { get; set; }
        public List<Cliente> listaDeClientesGeneral { get; set; } = new List<Cliente>();
        public List<Articulo> listaDeArticulosGeneral { get; set; } = new List<Articulo>();

        public List<Meses> meses { get; set; } = new List<Meses>();
       


    }
}
