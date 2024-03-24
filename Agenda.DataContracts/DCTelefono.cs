using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://agenda.datacontracts", Name = "Telefono")]
    public partial class DCTelefono
    {
        private int codTelefono;
        private string nroTelefono;

        //propiedades
        [WcfSerialization::DataMember(Name = "CodigoTelefono", IsRequired = true, Order = 0)]
        public int CodigoTelefono
        {
            get { return codTelefono; }
            set { codTelefono = value; }
        }

        [WcfSerialization::DataMember(Name = "NroTelefono", IsRequired = true, Order = 1)]
        public string NroTelefono
        {
            get { return nroTelefono; }
            set { nroTelefono = value; }
        }

        public override string ToString()
        {
            return nroTelefono;
        }
    }
}
