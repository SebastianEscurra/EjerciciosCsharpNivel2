using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Campesino: Trabajadores
    {
        public override string trabajar()
        {
            return "trabajo de campesino";
        }
    }
}
