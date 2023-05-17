using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Espadachin: Guerreros,ComboDeEspadas
    {
        public Espada espadaDeEspadachin=new Espada();

        public string hacerComboDeEspadas()
        {
            return "estoy haciendo combo de espadas";
        }
        public override string luchar()
        {
            return "pego con la espada";
        }
    }
}
