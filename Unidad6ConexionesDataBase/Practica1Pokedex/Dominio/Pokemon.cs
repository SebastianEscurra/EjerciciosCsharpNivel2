using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        [DisplayName("Número")]
        public int Numero { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Tipo")]
        public Elemento Tipo { get; set; }
        [DisplayName("Debilidad")]
        public Elemento Debilidad { get; set; }
        public string UrlImagen { get; set; }
    }
}
