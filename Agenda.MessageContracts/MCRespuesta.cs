using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class MCRespuesta
    {
        // atributos
        private bool respuesta;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "Respuesta")]
        public bool Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
    }
}
