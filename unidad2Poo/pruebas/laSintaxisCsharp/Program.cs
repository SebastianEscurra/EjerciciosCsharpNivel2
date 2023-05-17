using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laSintaxisCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            //tipos de datos nuevos strings, datetime
            Console.WriteLine(  "ingrese su numero: ");
            int a=int.Parse(Console.ReadLine());
            int b = a * 5;
            Console.WriteLine(  "resultado= " + b);
            
            //condicionales papa 


            //if
            if (a/b==15)
                Console.WriteLine("es igual a 15.");
            else
                Console.WriteLine("no es igual a 15");           
            //switch
            switch (a)
            {
                case 5:
                    Console.WriteLine("asi tiene un 5");
                    break;
            }


            //ciclos while do while for

            int j = 5;

            for (int x = 0; x < 5; x++)
            {
                while(j!=10)
                {
                    Console.WriteLine("vuelta" + (j-4));
                    j++;
                }
            }

            // vectores

            int[] numeros = new int[5];
            numeros[4] = 45;

            j = numeros[4];


            //funcion
            cambiarValor(ref j);
            Console.WriteLine(j);

            Console.WriteLine(saludar("sebastian"));

            Console.ReadKey();   // toma una letra importante por que sino sigue avanzando y termina su ejecución
        }

        //funciones

        static void cambiarValor(ref int j)
        {
            j = 999;
        }

        static string saludar(string nombre)
        {
            return "hola " + nombre;
        }
    }
}
