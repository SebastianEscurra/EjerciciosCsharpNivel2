using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6PracticaUml
{
    internal class Espacios
    {
        // Atributo

        private List<Sillas> listsillas = new List<Sillas>();//  Objeto lista de sillas
        private List <Mesas> listMesas= new List<Mesas> ();// Objeto lista de mesas

        // Propiedades
        public int tamañoM2 { get; set; }

        public List<Sillas> _listSillas { get { return listsillas; } set { listsillas = value; } } // Propiedad para acceder al listado de sillas 
        public List <Mesas> _listMesas {  get { return listMesas; } set { listMesas = value; } }  // Propiedad para acceder al listado de mesas

        // Metodos
        public void agregarSillas(int cantidad)
        {
            for (int x = 0; x < cantidad; x++)
            {
                listsillas.Add(new Sillas());
            }

        }

        public void agregarMesas(int cantidad)
        {
            for (int x = 0; x < cantidad; x++)
            {
                listMesas.Add(new Mesas());
            }

        }
    }
}
