using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Interfaces
{
    internal class Aguila : AnimalSalvaje, IFlyable
    {
        public string volar()
        {
            return "estoy volando como aguila";
        }

        public override string comunicarse()
        {
            return "gruño como aguila";
        }
    }
}
