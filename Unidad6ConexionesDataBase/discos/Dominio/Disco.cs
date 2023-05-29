using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Disco
    {
        public string titulo { get; set; }
        public int cantidadDeCanciones { get; set; }
        public DateTime fechaDeLanzamiento { get; set; }
        public Estilo estilo { get; set; }
        public string UrlImagen { get; set; }

       
    }
}
