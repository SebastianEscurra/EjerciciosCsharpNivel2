using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nivel2
{
    internal class ProgramVentas
    {
        static void Main(string[] args)
        {
            /*primer lote con 10 registros de productos, cada producto tiene:
            -codigo de articulo (3 digitos no correlativos)
           -precio
           -codigo de marca (1a10)
           Segundo lote con las ventas de la semana. Cada venta tiene:
           -codigo de articulo
           -cantidad
           -codigo de cliente
           este lote cierra con codigo de cliente 0.*/

            Articulo[] articulos = new Articulo[10];

            Console.WriteLine("cargamos los articulos:");
            

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();

                Console.Write("ingrese el codigo de articulo: ");
                articulos[i]._codigoDeArticulo = int.Parse(Console.ReadLine());
                Console.Write("ingrese el precio: ");
                articulos[i]._precio=float.Parse(Console.ReadLine());
                Console.Write("ingrese el codigo de marca (1-10)");
                articulos[i]._codigoMarca = int.Parse(Console.ReadLine());
            }

            Venta ventas = new Venta();
            
            Console.WriteLine("lote de ventas:");

            int clienteMax=0;
            float gasto=0, gastoMax=0;
            bool banderaGasto = false;
            int[] cantidadProductos = new int[10];

            Console.Write("ingrese el cod de articulo: ");
            ventas._codArticulo = int.Parse(Console.ReadLine());

            while (ventas._codArticulo != 0)
            {
                Console.Write("cantidad: ");
                ventas._cantidad = int.Parse(Console.ReadLine());
                Console.Write("codigo de cliente: ");
                ventas._codCliente = int.Parse(Console.ReadLine());
                for (int x = 0; x < 10; x++)
                {
                    if (articulos[x]._codigoDeArticulo == ventas._codArticulo)
                    {
                        // calculamos el gasto
                        gasto = articulos[x]._precio * ventas._cantidad;

                        //buscamos el cliente que mas gasto y cuanto
                        if (!banderaGasto) 
                        {
                            banderaGasto = true;
                            gastoMax = gasto;
                            clienteMax = ventas._codCliente;

                        } else if (gasto > gastoMax)
                        {
                            gastoMax = gasto;
                            clienteMax = ventas._codCliente;
                        }

                        //acumulamos en el vector la cantidad de ventas
                        cantidadProductos[x] += ventas._cantidad; 
                    }
                }
                //mostramos si el gato supera los $1500
                if (gasto > 1500)
                    Console.WriteLine("el cliente" + ventas._codCliente + "gasto mas de $1500, gasto $" + gasto );

                //se vuelven a pedir datos
                Console.Write("ingrese el cod de articulo: ");
                ventas._codArticulo = int.Parse(Console.ReadLine());
                
            }
            
            //mostramos el cliente maximo y el gasto
            Console.WriteLine("el cliente que mas gasto fue: " + clienteMax + " con un gasto de $" + gastoMax);

            //una vez cargado el vector con los productos vendidos buscamos cual es el que mas ventas tuvo
            int cantidadMax = cantidadProductos[0];
            int productoMax = 0;

            for (int x = 0; x < 10; x++)
            {
                if (cantidadProductos[x] > cantidadMax)
                {
                    cantidadMax = cantidadProductos[x];
                    productoMax = x;
                }
            }

            //mostramos el producto que mas se vendio

            Console.WriteLine("el producto con mas ventas es: " + articulos[productoMax]._codigoDeArticulo + 
                " con " + cantidadMax + " vendidos.");
        }
                      

    }
        
}

