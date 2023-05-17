using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono tel1 = new Telefono("a10s", "samsung");
            tel1.numeroTelefonico = "01127672955";
            tel1._codigoOperador = 3;
            Console.WriteLine($"celular {tel1.marca} {tel1.modelo} con numero de telefono {tel1.numeroTelefonico} y codigo de operador {tel1._codigoOperador} ");
            Console.WriteLine(tel1.llamar());
            Console.WriteLine(tel1.llamar("matias"));
            Telefono tel2 = new Telefono("zz","motorola");
            tel2.numeroTelefonico = "1120203030";
            tel2._codigoOperador = 5;
            Console.WriteLine("celular: " + tel2.marca + "\nmodelo: " + tel2.modelo + "\nnumero de telefono: " + tel2.numeroTelefonico + "\ncodigo de operador: " + tel2._codigoOperador );
            Console.WriteLine(tel2.llamar());
            Console.WriteLine(tel2.llamar("jaime"));
            Console.WriteLine(tel1.GetHashCode());
            Console.WriteLine(tel2.GetHashCode());
        }
    }
}
