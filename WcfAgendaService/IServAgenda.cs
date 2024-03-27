using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAgendaService
{
    [ServiceContract(Namespace = "http://agenda.modelo.ServiceContracts", Name = "SCAgenda", SessionMode = SessionMode.Allowed, ProtectionLevel = ProtectionLevel.None)]
    public interface IServAgenda
    {
        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ObtenerPersonas", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCListaPersonas ObtenerPersonas();

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "SeleccionaPersona", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCPersona SeleccionaPersona(Agenda.MessageContracts.MCCodigo request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "InsertaPersona", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCRespuesta InsertaPersona(Agenda.MessageContracts.MCPersona request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "ActualizaPersona", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCRespuesta ActualizaPersona(Agenda.MessageContracts.MCPersona request);

        [OperationContract(IsTerminating = false, IsInitiating = true, IsOneWay = false, AsyncPattern = false, Action = "EliminaPersona", ProtectionLevel = ProtectionLevel.None)]
        Agenda.MessageContracts.MCRespuesta EliminaPersona(Agenda.MessageContracts.MCCodigo request);
    }
}
