using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda03.RefServAgenda
{
    public partial class Persona
    {
        public override string ToString()
        {
            return Apellidos + ", " + Nombre;
        }
    }
}
