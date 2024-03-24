using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class MCCodigo
    {
        // atributos
        private int codigoPersona;
        // propiedad
        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "CodigoPersona")]
        public int CodigoPersona
        {
            get { return codigoPersona; }
            set { codigoPersona = value; }
        }
    }
}
