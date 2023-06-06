using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int id { get; set; }
        public Cliente cliente { get; set; }
        public Producto tipoDeCalzado { get; set; }
        public Producto descripcion { get; set; }
        public int cantidad { get; set; }
        public string presupuestoFinal { get; set; }
        public DateTime fechaDePedido { get; set; }
        public DateTime fechaDeEntrega { get; set; }
        public string estado { get; set; }

    }
}
