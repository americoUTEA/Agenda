﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.be
{
    public class BEPersona
    {
        public int codPersona { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }

        public List<BETelefono> telefonos { get; set; }

        public override string ToString()
        {
            return apellidos + ", " + nombre;
        }
    }
}
