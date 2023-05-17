using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia7PracticaHabitantesReinoIntegracionDeConceptos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mago mago1= new Mago();
            Console.WriteLine(mago1.baculoDeMago.lanzarMagia());
            Console.WriteLine(mago1.luchar());
            Console.WriteLine(mago1.invocar());

            MagoDeFuego magoFuego = new MagoDeFuego();
            Console.WriteLine(magoFuego.baculoDeMago.lanzarMagia());
            Console.WriteLine(magoFuego.luchar());
            Console.WriteLine(magoFuego.invocar());

            Arquero arquero1 = new Arquero();
            arquero1.nombreDelReino = "reino babosa";

            Arquero arquero2 = new Arquero();
            arquero2.nombreDelReino = "reino anarquia";
            Console.WriteLine("\n" + arquero1.nombreDelReino);
            Console.WriteLine("\n" + arquero2.nombreDelReino);

            Console.WriteLine("\n" + arquero1.arcoDeArquero.disparar());
            Console.WriteLine(arquero2.lluviaDeFlechas());
            Console.WriteLine(arquero2.luchar());
        }
    }
}
