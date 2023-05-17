using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Interfaces
{
    internal class Canario : AnimalDomestico, IFlyable
    {
        public string volar()
        {
            return "volando como canario";
        }
        public override string comunicarse()
        {
            return "silvando como canario";
        }
    }
}
