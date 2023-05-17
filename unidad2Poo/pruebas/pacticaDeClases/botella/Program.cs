using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella bot1 = new Botella("verde", "plastico");
            bot1.cargar(20);
            Console.WriteLine("carga actual: "+ bot1.cargaActual); 
            Console.WriteLine("el precio a abonar por la carga es: " + bot1.cargar());
            Console.WriteLine(bot1.tomar(50));
            Console.WriteLine(bot1.tomar(10));
            Console.WriteLine("el precio a abonar por la carga es: " + bot1.cargar());
            Console.WriteLine(bot1.GetHashCode());
            Botella bot2 = new Botella("lk","jf");
            Console.WriteLine(bot2.GetHashCode());
        }
    }
}
