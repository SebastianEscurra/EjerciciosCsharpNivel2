using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class MagoDeHielo: Mago, PuedeInvocar
    {
        public int nivelDeHechiceroHielo { get; set; }
        public override string invocar()
        {
            return "invoco animal de hielo";
        }
        public override string luchar()
        {
            return "lanzo hechizo de hielo";
        }
    }
}
