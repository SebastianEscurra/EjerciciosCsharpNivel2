using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio { get; set; }
        public string descripcion { get; set; }
        public string UrlImagen { get; set; }   
        public override string ToString()
        {
            int contador = 0;
            if (contador == 0)
            {
                contador++;
                return nombre;
            }
            else
                return UrlImagen;
        }
        
    }
}
