using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo moto = new Moto(); // permite ingresar a los atributos de vehiculo pero no de moto
            Moto moto1 = new Moto();//permite ingresar tanto a los propios como a los de la clase base
            Auto deportivo= new AutoDeportivo(); // no llega a los atributos especificos pero si a los que estan en la herencia desde base hasta la que se declara al pricipio
            AutoUrbano urbano = new AutoUrbano(); //alcance hasta los especificos
            Vehiculo camion = new Camioneta();//alcance solo a la herencia

            moto.motor="ma";
            moto1.cascos = "caca";
            moto1.motor = "momo";

            deportivo.motor = "meme";
            deportivo.descapotable = true;

            urbano.motor = "masm";
            urbano.descapotable = false;
            urbano.iaEstacionamiento = true;

            //prueba de tipos de elementos valor o referencia
            camion.motor = "mol";
            Vehiculo camioneta1 = camion;// la variable camioneta1 hace referencia a camion, comparten el mismo espacio de memoria dinamica.
            camioneta1.motor = "mamamamam";
            camioneta1 = new Vehiculo();//creamos una nueva referencia. la anterior se pierde.
            Console.WriteLine(camioneta1.motor);

            //prueba de colecciones

            //creamos objetos tipo camioneta y le damos valor a uno de sus atributos
            Camioneta cam1 = new Camioneta();
            Camioneta cam2 = new Camioneta();
            Camioneta cam3 = new Camioneta();
            cam1.motor = "mama";
            cam2.motor = "papa";
            cam3.motor = "hijo";
              
            //creamos la coleccion tipo list con el objeto tipo camioneta y instaciamos la variable
            List<Camioneta> listaCamionetas = new List<Camioneta>();

            //agregamos objetos a la lista
            listaCamionetas.Add(cam1);
            listaCamionetas.Add(cam2);
            listaCamionetas.Add(cam3);

            //iteramos con foreach
            Console.WriteLine("motores: ");

            foreach (var  cam in listaCamionetas)
            {
                Console.WriteLine(cam.motor);
            }

            Console.WriteLine("cantidad de camionetas: "+ listaCamionetas.Count);//contamos cuantos objetos hay en la coleccion
              
            //borramos y hacemos pruebas
            listaCamionetas.Remove(cam1);
            listaCamionetas[1].motor = "cacaca";

            foreach (var camioneta in listaCamionetas)
            {
                Console.WriteLine(camioneta.motor);
            }

            Console.WriteLine(listaCamionetas.Count);
        }
    }
}
