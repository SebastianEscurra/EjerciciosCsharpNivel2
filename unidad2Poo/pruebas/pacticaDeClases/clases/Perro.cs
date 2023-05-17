using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Perro
    {
        private string nombre;
        private string color;
        private string origen;
        private string alimento = "dog chow cachorro";
       
        public Perro(string nombre,string color, string origen)
        {
            this.nombre = nombre;
            this.color = color;
            this.origen = origen;
        }

        public string alimentacion
        {
            get { return alimento; }
            set { alimento = value; }
        }

        public void presentarse()
        {
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("color: " + color);
            Console.WriteLine("origen: " + origen);
        }

        public string ladrar()
        {
            return "guau";
        }

        public string correr()
        {
            return "soy el perro " + nombre + " y estoy corriendo.";
        }
    }
}
