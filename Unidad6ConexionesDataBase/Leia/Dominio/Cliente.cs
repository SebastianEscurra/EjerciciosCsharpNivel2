using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int numeroDeTelefono { get; set; }
        public string email { get; set; }
        public override string ToString()
        {
            return nombre;
        }
    }
}
