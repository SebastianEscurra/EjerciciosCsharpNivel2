using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Asociacion
{
    internal class Auto: Vehiculo
    {
        
        public Carroceria carroceria = new Carroceria();
        

        public Motor motor;
        public Carroceria carroceriaNueva;
       
    }
}
