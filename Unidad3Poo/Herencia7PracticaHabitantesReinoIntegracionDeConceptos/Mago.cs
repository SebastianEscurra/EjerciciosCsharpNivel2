using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Mago :Guerreros,PuedeInvocar
    {
        public Baculo baculoDeMago=new Baculo();

        public virtual string invocar()
        {
            return "invocando anmal pequeño";
        }
        public override string luchar()
        {
            return "lanzo hechizo";
        }
    }
}
