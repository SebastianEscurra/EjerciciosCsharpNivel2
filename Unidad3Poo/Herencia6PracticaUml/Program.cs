using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela1 = new Escuela();



            escuela1.agregarAula(5);

            escuela1.listaula[0].agregarSillas(5);

            foreach (var item in escuela1.listaula[0]._listSillas)
            {
                Console.WriteLine(item._estado);
            }

            escuela1.listaula[0]._listSillas[0].romper();

            Console.WriteLine("\n\n");


            foreach (var item in escuela1.listaula[0]._listSillas)
            {
                Console.WriteLine(item._estado);
            }

            Console.WriteLine(escuela1.listaula[0]._listSillas[0]._altura);



            //escuela1.secretaria._listDirectivos.Add(new Directivo("Sebastian Escurra", "Lomas de Zamora", "1127672955"));

            //Console.WriteLine(escuela1.secretaria.);
            //Console.WriteLine(escuela1.secretaria._listDirectivos[0].datos.ubicacion);
            //Console.WriteLine(escuela1.secretaria._listDirectivos[0].datos.telefono);













            Console.WriteLine(escuela1.abrirCerrarEscuela(true));

        }
    }
}
