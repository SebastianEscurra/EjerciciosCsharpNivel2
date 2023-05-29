using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programasimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int porcentaje = 0;

            Console.Write("ingrese su nombre completo: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("bienvenido " + nombre + " esperamos que disfrute de programar en vsC");

            Console.WriteLine("comenzamos haciendo un programa para registrar el progreso en su curso");
            Console.Write("digite el numero de la unidad en la que se encuentra: ");
            int unidad=int.Parse(Console.ReadLine());
            Console.WriteLine("completo esta unidad?");
            string completado=Console.ReadLine();
            if (completado != "si")
            {
                Console.WriteLine("ingrese el porcentaje de progreso");
                porcentaje = int.Parse(Console.ReadLine());
            }
            else
                porcentaje = 100;

            if (porcentaje==100 && unidad==8)
                Console.WriteLine("Felicitaciones terminaste el curso!!!");
            else
            {
                Console.WriteLine($"a seguir estas en la unidad {unidad} solo te faltan {8 - unidad} unidades para terminar!");
            }

            Console.WriteLine("fin del programa");

        }
    }
}
