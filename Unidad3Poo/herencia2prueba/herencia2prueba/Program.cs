using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Remera> listaRemeras = new List<Remera>();
            List<Pantalon> listaPantalones = new List<Pantalon>();


            Pantalon p1 = new Pantalon();
            Pantalon p2 = new Pantalon();
            Pantalon p3 = new Pantalon();

            Remera r1 = new Remera();
            Remera r2 = new Remera();
            Remera r3 = new Remera();


            listaPantalones.Add(p1);
            listaPantalones.Add(p2);
            listaPantalones.Add(p3);
            listaRemeras.Add(r1);
            listaRemeras.Add(r2);
            listaRemeras.Add(r3);
            p1.tela = "gabardina";
            p1.talle = 5;
            p2.tela = "jean";
            p2.talle = 3;
            p3.tela = "algodon";
            p3.talle = 1;
            r1.tela = "licra";
            r1.talle = 1;
            r2.tela = "modal";
            r2.talle = 2;
            r3.tela = "polyester";
            r3.talle = 4;

            foreach (Pantalon pantalon in listaPantalones)
            {
                Console.WriteLine("tela del pantalon: "+ pantalon.tela);
                Console.WriteLine("talle del pantalon: " + pantalon.talle);
            }

            foreach (Remera rem in listaRemeras)
            {
                Console.WriteLine("tela de la remera: "+ rem.tela);
                Console.WriteLine("talle de la remera: " + rem.talle);
            }
            Console.WriteLine(listaPantalones.Count + listaRemeras.Count);
            List<Indumentaria> productos =new List<Indumentaria>();

            for (int x = 0; x < listaPantalones.Count; x++)
            {
                productos.Add(listaPantalones[x]);
            }

            for (int x = 0; x < listaRemeras.Count; x++)
            {
                productos.Add(listaRemeras[x]);
            }

            foreach (var item in productos)
            {
                Console.WriteLine(item.tela);

            }


            //sobreescritura de metodos
            Console.WriteLine(productos[5].ToString());


        }
    }
}
