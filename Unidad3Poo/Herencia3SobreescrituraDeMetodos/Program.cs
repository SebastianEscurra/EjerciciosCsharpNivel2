using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3SobreescrituraDeMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro p1= new Perro();
            Console.WriteLine(p1.comunicarse());

            Leon l1 = new Leon();
            Console.WriteLine(l1.comunicarse());

            //casteo explicito: nos sirve para volver a acceder a los datos de la variable original que era tipo heredera(hija).
            Animales a1 = p1;

            Perro p2 = (Perro)a1;
            

            //polimorfismo: se da cuando con un mismo estimulo tenemos diferentes resultados. gracias a la sobreescritura 
            //podremos lograr este polimorfismo.
            List<Animales> listaanimales = new List<Animales>();
            listaanimales.Add(p1);
            listaanimales.Add(l1);
            listaanimales.Add(new Perro());
            listaanimales.Add(new Leon());

            foreach (var item in listaanimales)
            {
                Console.WriteLine(item.comunicarse());
            }

        }
    }
}
