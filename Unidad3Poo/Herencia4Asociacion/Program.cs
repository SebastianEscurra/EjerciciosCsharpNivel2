using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4Asociacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1= new Auto();

            a1.motor = new Motor();
;
            Console.WriteLine(a1.motor.Potencia);
            a1.motor.Potencia=55;
            Console.WriteLine(a1.motor.Potencia);

            Console.WriteLine(a1.carroceria.Ancho);
            a1.carroceria.Ancho = 563;
            //¿Como puedo acceder a los datos de carroceria del constructor? no se puede por que los elementos dentro del
            //constructor solo se puden cargar con valores cuando el constructor se ejecuta. podes pedir datos desde el constructor
            //o que el objeto asociado (por compocicion o agregacion) este instanciado dentro de la clase pero fuera del constructor.

            Console.WriteLine(a1.carroceria.Ancho);

            a1.carroceriaNueva = new Carroceria();
            a1.carroceriaNueva.Ancho = 66;
            Console.WriteLine(a1.carroceriaNueva.Ancho);

        }
    }
}
