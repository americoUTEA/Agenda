using System;
using WcfSerialization = global::System.Runtime.Serialization;

namespace Agenda.DataContracts
{
    [WcfSerialization::DataContract(Namespace = "http://agenda.datacontracts", Name = "Persona")]
    public partial class DCPersona
    {
        //atributos
        private int codigo;
        private string nombre;
        private string apellidos;
        private string direccion;
        private DCListaTelefono telefonos;

        //propiedades
        [WcfSerialization::DataMember(Name = "Codigo", IsRequired = true, Order = 0)]
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        [WcfSerialization::DataMember(Name = "Nombre", IsRequired = true, Order = 1)]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [WcfSerialization::DataMember(Name = "Apellidos", IsRequired = true, Order = 2)]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [WcfSerialization::DataMember(Name = "Direccion", IsRequired = false, Order = 3)]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [WcfSerialization::DataMember(Name = "Telefonos", IsRequired = true, Order = 4)]
        public DCListaTelefono Telefonos
        {
            get { return telefonos; }
            set { telefonos = value; }
        }

        public override string ToString()
        {
            return apellidos + ", " + nombre;
        }
    }
}
