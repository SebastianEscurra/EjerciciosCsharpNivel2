using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispenser
{
    internal class Dispenser
    {
        //atributos
        private int codArticulo;
        private string marca;
        private float precio;
        private string color;
        private string estado;
        private int estadoDelAgua = 0;
        //propiedades
        public string bidones { get; set; } 
        public int _codArticulo
        {
            get { return codArticulo; }
        }
        public string  _marca
        {
            get { return marca; }
            set
            {
                if (value == "cool")
                {
                    this.marca = value;
                    color = "negro";
                    precio = 1.500f;
                }
                else
                {
                    this.marca = value;
                    color = "blanco";
                    precio = 2.500f;
                }
            }
        }
        public string _color 
        {
            get { return color; }
        }

        public float _precio
        {
            get { return precio; }
        }

        //constructor
        public Dispenser(int codModelo)
        {
            this.codArticulo = codModelo;
            estado = "apagado";
        }
        
        //metodos

        public string encender()
        {
            estado = "encendido";
            return "encendiendo";
        }
        public string apagar()
        {
            estado = "apagado";
            return "apagando";
        }

        public int aguaCaliente()
        {
            Console.WriteLine("sirviendo agua caliente");
            if (estado == "encendido")
                estadoDelAgua = -500;
            else
                estadoDelAgua = 0;
            return estadoDelAgua;
        }

        public int aguaFria()
        {
            Console.WriteLine("sirviendo agua fria");

            if (estado == "encendido")
                estadoDelAgua = 300;
            else
                estadoDelAgua = 0;

                return estadoDelAgua;
        }

    }
}
