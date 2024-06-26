﻿using Agenda.be;
using Agenda.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.bll
{
    public class blAgenda
    {
        public bool insertaPersona(BEPersona pPersona)
        {
            var dataAccess = new daPersona();
            // aqui la logica de negocio
            if (pPersona.direccion == string.Empty)
                return false;
            return dataAccess.insertaPersona(pPersona);
        }

        public bool actualizaPersona(BEPersona pPersona)
        {
            var dataAccess = new daPersona();
            // aqui la logica de negocio
            if (pPersona.codPersona == 3)
                return false;
            return dataAccess.actualizaPersona(pPersona);
        }

        public bool eliminarPersona(int pCodPersona)
        {
            var dataAccess = new daPersona();
            // aqui la logica de negocio
            if (pCodPersona == 1)
                return false;
            return dataAccess.eliminarPersona(pCodPersona);
        }
        public BEPersona seleccionaPersona(int pCodigo)
        {
            var dataAccess = new daPersona();
            return dataAccess.seleccionaPersona(pCodigo);
        }

        public List<BEPersona> seleccionarPersonas()
        {
            var dataAccess = new daPersona();
            return dataAccess.seleccionarPersonas();
        }
    }
}
