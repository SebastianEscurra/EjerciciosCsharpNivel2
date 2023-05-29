using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpeta
{
    internal class Telefono
    {
        public string modelo { get; }
        public string marca { get; }
        public string numeroTelefonico { get; set; }
        private int codigoOperador;
        public int _codigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

       
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        public string llamar()
        {
            return "realizando llamada.";
        }

        public string llamar(string contacto)
        {
            return "llamando a " + contacto;
        }
    }
}
