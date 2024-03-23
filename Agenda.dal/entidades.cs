using System;
using System.Collections.Generic;

namespace Agenda.dal
{
    public partial class datos
    {
        public List<persona> PersonasData { get; set; }
        public datos()
        {
            PersonasData = new List<persona>();
            var tel1 = new telefono(){ codTelefono = 1, nroTelefono = "123456789" };
            var tel2 = new telefono(){ codTelefono = 2, nroTelefono = "234567891" };
            var tel3 = new telefono(){ codTelefono = 3, nroTelefono = "345678912" };
            var tel4 = new telefono(){ codTelefono = 4, nroTelefono = "456789123" };
            var tel5 = new telefono(){ codTelefono = 5, nroTelefono = "567891234" };
            var tel6 = new telefono(){ codTelefono = 6, nroTelefono = "678912345" };
            var per1 = new persona(){ codPersona = 1, nombre = "Naruto", apellidos = "Uzumaki", direccion = "Konoha S/N"};
            per1.telefonos = new List<telefono>();
            per1.telefonos.Add(tel1);
            per1.telefonos.Add(tel2);
            PersonasData.Add(per1);
            var per2 = new persona() { codPersona = 2, nombre = "Sakura", apellidos = "Haruno", direccion = "Haruno Family S/N" };
            per2.telefonos = new List<telefono>();
            per2.telefonos.Add(tel3);
            per2.telefonos.Add(tel4);
            per2.telefonos.Add(tel5);
            PersonasData.Add(per2);
            var per3 = new persona() { codPersona = 3, nombre = "Sasuke", apellidos = "Uchiha", direccion = "Barrio Uchiha S/N" };
            per3.telefonos = new List<telefono>();
            per3.telefonos.Add(tel6);
            PersonasData.Add(per3);
            var per4 = new persona() { codPersona = 4, nombre = "Kakasi", apellidos = "Hatake", direccion = "Colmillo blanco S/N" };
            PersonasData.Add(per4);
        }
    }
    public partial class telefono
    {
        public int codTelefono { get; set; }
        public string nroTelefono { get; set; }
    }

    public partial class persona
    {
        public int codPersona { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }

        public List<telefono> telefonos { get; set; }
    }
}
