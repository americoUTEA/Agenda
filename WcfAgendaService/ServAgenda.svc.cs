using Agenda.bll;
using Agenda.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAgendaService
{
    public class ServAgenda : IServAgenda
    {

        public MCListaPersonas ObtenerPersonas(MCCodigo request)
        {
            var objResponse = new MCListaPersonas();
            var objAgenda = new blAgenda();
            var listaPersonas = objAgenda.seleccionarPersonas();
            objResponse.Personas = Traductor.TraduceListaPersonas(listaPersonas);
            return objResponse;
        }

        public MCPersona SeleccionaPersona(MCCodigo request)
        {
            var objResponse = new MCPersona();
            var objAgenda = new blAgenda();
            var objPersona = objAgenda.seleccionaPersona(request.CodigoPersona);
            objResponse.DatosPersona = Traductor.TraducePersona(objPersona);
            return objResponse;
        }

        public MCRespuesta InsertaPersona(MCPersona request)
        {
            var objResponse = new MCRespuesta();
            var objAgenda = new blAgenda();
            var objPersona = Traductor.TraducePersona(request.DatosPersona);
            objResponse.Respuesta = objAgenda.insertaPersona(objPersona);
            return objResponse;
        }

        public Agenda.MessageContracts.MCRespuesta ActualizaPersona(Agenda.MessageContracts.MCPersona request)
        {
            var objResponse = new MCRespuesta();
            var objAgenda = new blAgenda();
            var objPersona = Traductor.TraducePersona(request.DatosPersona);
            objResponse.Respuesta = objAgenda.actualizaPersona(objPersona);
            return objResponse;
        }

        public Agenda.MessageContracts.MCRespuesta EliminaPersona(Agenda.MessageContracts.MCCodigo request)
        {
            var objResponse = new MCRespuesta();
            var objAgenda = new blAgenda();
            objResponse.Respuesta = objAgenda.eliminarPersona(request.CodigoPersona);
            return objResponse;
        }
    }
}
