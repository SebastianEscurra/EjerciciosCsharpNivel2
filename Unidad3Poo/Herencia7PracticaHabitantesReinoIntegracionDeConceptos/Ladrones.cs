using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Ladrones: HabitantesDelReino
    {
        public int nivel { get; set; }
        public string robar()
        {
            return "robando";
        }
    }
}
