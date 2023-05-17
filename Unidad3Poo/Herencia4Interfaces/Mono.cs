using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Interfaces
{
    internal class Mono : AnimalSalvaje, IScrambleable
    {
        public string trepar()
        {
            return "estoy trepando como mono.";
        }
        public override string comunicarse()
        {
            return "gritando como mono";
        }
    }
}
