using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Trabajadores : HabitantesDelReino
    {
        public int nivel { get; set; }
        public virtual string trabajar()
        {
            return "sin trabajo";
        }

    }
}
