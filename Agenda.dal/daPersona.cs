using Agenda.be;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Agenda.dal
{
    public class daPersona
    {
        public datos datosPersonas = new datos();
        public bool insertaPersona(bePersona pPersona)
        {
            var per = new persona() { codPersona = pPersona.codPersona, 
                                      nombre = pPersona.nombre,
                                      apellidos = pPersona.apellidos, 
                                      direccion = pPersona.direccion };

            foreach (var item in pPersona.telefonos)
	        {
                var tel = new telefono(){ codTelefono = item.codTelefono, nroTelefono = item.nroTelefono };
                per.telefonos.Add(tel);
	        }
            datosPersonas.PersonasData.Add(per);
            return true;
        }

        public bool actualizaPersona(bePersona pPersona)
        {
            var result = from per in datosPersonas.PersonasData where per.codPersona == pPersona.codPersona select per;
            result.First().codPersona = pPersona.codPersona;
            result.First().nombre = pPersona.nombre;
            result.First().apellidos = pPersona.apellidos;
            result.First().direccion = pPersona.direccion;
            result.First().telefonos.Clear();
            foreach (var tel in pPersona.telefonos)
            {
                var tele = new telefono() { codTelefono = tel.codTelefono, nroTelefono = tel.nroTelefono };
                result.First().telefonos.Add(tele);
            }
            return true;
        }

        public bool eliminarPersona(int pCodigo)
        {
            var item = datosPersonas.PersonasData.First(per => per.codPersona == pCodigo);
            datosPersonas.PersonasData.Remove(item);
            return true;
        }
        public bePersona seleccionaPersona(int pCodigo)
        {
            var result = from per in datosPersonas.PersonasData where per.codPersona == pCodigo select per;
            var pPersona = new bePersona();
            pPersona.codPersona = result.First().codPersona;
            pPersona.nombre = result.First().nombre;
            pPersona.apellidos = result.First().apellidos;
            pPersona.direccion = result.First().direccion;
            pPersona.telefonos = new List<beTelefono>();
            if (result.First().telefonos != null)
            {

                foreach (var tel in result.First().telefonos)
                {
                    var tele = new beTelefono() { codTelefono = tel.codTelefono, nroTelefono = tel.nroTelefono };
                    pPersona.telefonos.Add(tele);
                }
            }
            return pPersona;
        }

        public List<bePersona> seleccionarPersonas()
        {
            var resultado = new List<bePersona>();
            foreach (var item in datosPersonas.PersonasData)
            {
                resultado.Add(seleccionaPersona(item.codPersona));
            }
            return resultado;
        }
    }
}
