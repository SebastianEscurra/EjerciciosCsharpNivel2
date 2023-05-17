using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Interfaces
{
    internal class Gato : AnimalDomestico, IScrambleable
    {
        public string trepar()
        {
            return "estoy trepando como gato";
        }

        public override string comunicarse()
        {
            return "maullo.. maullo";
        }
    }
}
