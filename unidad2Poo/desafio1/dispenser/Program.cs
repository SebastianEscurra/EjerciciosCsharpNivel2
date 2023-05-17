using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispenser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dispenser cool = new Dispenser(150);
            cool._marca = "cool";
            Console.WriteLine("bidon de fabrica: "+ cool.bidones);
            cool.bidones = "cimes";
            Console.WriteLine("descripcion del producto: ");
            Console.WriteLine($"codigo: {cool._codArticulo}");
            Console.WriteLine($"marca: {cool._marca}" );
            Console.WriteLine("color: "+ cool._color);
            Console.WriteLine("precio: " + cool._precio);
            Console.WriteLine("\nusamos el producto");
            Console.WriteLine(cool.encender());
            Console.WriteLine(cool.aguaFria());
            Console.WriteLine(cool.aguaCaliente());
            cool.apagar();
            Console.WriteLine(cool.aguaCaliente());

            Dispenser atma = new Dispenser(151);
            atma._marca = "atma";
            Console.WriteLine("descripcion del producto: ");
            Console.WriteLine($"codigo: {atma._codArticulo}");
            Console.WriteLine($"marca: {atma._marca}");
            Console.WriteLine("color: " + atma._color);
            Console.WriteLine("precio: " + atma._precio);
            Console.WriteLine("\nusamos el producto");
            Console.WriteLine(atma.encender());
            Console.WriteLine(atma.aguaFria());
            Console.WriteLine(atma.aguaCaliente());
            atma.apagar();
            Console.WriteLine(atma.aguaCaliente());


        }
    }
}
