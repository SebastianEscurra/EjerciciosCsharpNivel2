﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon
    {
        public int numero { get; set; }

        public string nombre { get; set; }
        
        public string descripcion { get; set; }

        public string tipo { get; set; }
        public string urlImagen { get; set; }
    }
}
