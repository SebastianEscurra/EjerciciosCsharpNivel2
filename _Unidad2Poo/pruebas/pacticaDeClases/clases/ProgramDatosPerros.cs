using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class ProgramDatosPerros
    {
        static void Main(string[] args)
        {
            Perro perro1=new Perro ("bella","rubia","budge");

            perro1.presentarse();
            perro1.alimentacion = "hueso de pollo";
            Console.WriteLine("el alimento que como es " + perro1.alimentacion);
            Console.WriteLine(perro1.ladrar());
            Console.WriteLine(perro1.correr());
            Console.WriteLine(perro1.ladrar());
            Console.WriteLine(perro1.ladrar());

            Console.WriteLine("\nFin del programa.");
        }
    }
}
