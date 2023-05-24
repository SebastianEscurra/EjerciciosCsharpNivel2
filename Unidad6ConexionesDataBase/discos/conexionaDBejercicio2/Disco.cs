using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionaDBejercicio2
{
    internal class Disco
    {
        public string titulo { get; set; }
        public int cantidadDeCanciones { get; set; }
        public DateTime fechaDeLanzamiento { get; set; }
        public Estilo estilo { get; set; }
        public string UrlImagen { get; set; }

       
    }
}
