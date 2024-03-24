using System;
using WCF = global::System.ServiceModel;

namespace Agenda.MessageContracts
{
    [WCF::MessageContract(IsWrapped = false)]
    public partial class MCListaPersonas
    {
        private DataContracts.DCListaPersonas personas;

        [WCF::MessageBodyMember(Namespace = "http://agenda.modelo.ServiceContracts", Name = "Personas")]
        public DataContracts.DCListaPersonas Personas
        {
            get { return personas; }
            set { personas = value; }
        }
    }
}
