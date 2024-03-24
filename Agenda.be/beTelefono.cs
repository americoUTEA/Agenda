using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.be
{
    public class BETelefono
    {
        public int codTelefono { get; set; }
        public string nroTelefono { get; set; }

        public override string ToString()
        {
            return nroTelefono;
        }
    }
}
