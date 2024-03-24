using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class MCPersona
    {
        // atributos
        private DataContracts.DCPersona datosPersona;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "DatosPersona")]
        public DataContracts.DCPersona DatosPersona
        {
            get { return datosPersona; }
            set { datosPersona = value; }
        }
    }
}
