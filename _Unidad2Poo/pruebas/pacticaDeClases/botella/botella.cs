using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace botella
{
    internal class Botella
    {
        private string color;
        private string material;
        private int capacidad;
        public int cargaActual { get; set; }
        public Botella(string color,string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cargaActual=0;
        }
        public int cargar()
        {
            int monto=1000;
            if (cargaActual == 0)
            {
                Console.WriteLine("botella vacia vas a cargar el %100");
                this.cargaActual = 100;
                return monto;
            }else
            {
                
                Console.WriteLine("vas a cargar: %" + (100-cargaActual));
                monto = (100-cargaActual) * 1000 / 100;
                cargaActual = 100;
                return monto;
            }                      
        }

        public int cargar (int recarga)
        {
            int monto = 1000;
            cargaActual += recarga;
            return (recarga * 100) / monto;
            //monto-100
            //recarga

        }

        public string tomar(int cuantoTomaste)
        {
            cargaActual -= cuantoTomaste;
            return "luego de tomar la botella queda con %" + cargaActual + " de carga";
        }
        


        
    }
}
