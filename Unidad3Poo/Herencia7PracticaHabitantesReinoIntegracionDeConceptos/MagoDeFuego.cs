using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class MagoDeFuego: Mago,PuedeInvocar
    {
        public int nivelDeHechiceroFuego { get; set; }
        public override string invocar()
        {
            return "invoco animal de fuego";
        }
        public override string luchar()
        {
            return "lanzo hechizo de fuego";
        }
    }
}
