using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Arquero: Guerreros,HacerLluviaDeFlechas
    {
        public Arco arcoDeArquero=new Arco();

        public string lluviaDeFlechas()
        {
            return "lluvia de flechas";
        }

        public override string luchar()
        {
            return "disparo una flecha";
        }
    }
}
