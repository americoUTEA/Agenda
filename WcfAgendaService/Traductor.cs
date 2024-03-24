using Agenda.be;
using Agenda.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfAgendaService
{
    public class Traductor
    {
        private static DCTelefono TraduceTelefono(BETelefono origen)
        {
            DCTelefono destino = new DCTelefono();
            destino.CodigoTelefono = origen.codTelefono;
            destino.NroTelefono = origen.nroTelefono;
            return destino;
        }

        private static BETelefono TraduceTelefono(DCTelefono origen)
        {
            BETelefono destino = new BETelefono();
            destino.codTelefono = origen.CodigoTelefono;
            destino.nroTelefono = origen.NroTelefono;
            return destino;
        }

        public static DCPersona TraducePersona(BEPersona origen)
        {
            DCPersona destino = new DCPersona();
            destino.Codigo = origen.codPersona;
            destino.Apellidos = origen.apellidos;
            destino.Nombre = origen.nombre;
            destino.Direccion = origen.direccion;
            destino.Telefonos = TraduceListaTelefonos(origen.telefonos);
            return destino;
        }

        public static BEPersona TraducePersona(DCPersona origen)
        {
            BEPersona destino = new BEPersona();
            destino.codPersona = origen.Codigo;
            destino.apellidos = origen.Apellidos;
            destino.nombre = origen.Nombre;
            destino.direccion = origen.Direccion;
            destino.telefonos = TraduceListaTelefonos(origen.Telefonos);
            return destino;
        }

        public static DCListaTelefono TraduceListaTelefonos(List<BETelefono> origen)
        {
            var destino = new DCListaTelefono();
            destino.AddRange(origen.Select(TraduceTelefono));
            return destino;
        }

        public static List<BETelefono> TraduceListaTelefonos(DCListaTelefono origen)
        {
            var destino = new List<BETelefono>();
            destino.AddRange(origen.Select(TraduceTelefono));
            return destino;
        }

        public static DCListaPersonas TraduceListaPersonas(List<BEPersona> origen)
        {
            var destino = new DCListaPersonas();
            destino.AddRange(origen.Select(TraducePersona));
            return destino;
        }

        public static List<BEPersona> TraduceListaPersonas(DCListaPersonas origen)
        {
            var destino = new List<BEPersona>();
            destino.AddRange(origen.Select(TraducePersona));
            return destino;
        }
    }
}