using System;
using System.Collections.Generic;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataContracts
{
    [WcfSerialization::CollectionDataContract(Namespace = "http://agenda.datacontracts")]
    public partial class DCListaTelefono : List<DCTelefono>
    {
    }
}
