using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Escuela
    {
        public string estadoEscuela = "cerrada";



        public List<Aula> listaula =new List<Aula>();
        public Direccion direccion;
        public Secretaria secretaria=new Secretaria();
        
        public List<Aula> _listAula
        {
            get { return listaula; }

            set { listaula = value; }
        }


        

        public string abrirCerrarEscuela(bool abierta)
        {
            if (abierta)
            {
                this.estadoEscuela = "abierta";
                return "abriendo escuela";
            }
            else
                return "cerrando escuela";
        }

        public void agregarAula(int cantidad)
        {
            for (int x = 0; x < cantidad; x++)
            {
                listaula.Add(new Aula());
            }
        }

    }
}
