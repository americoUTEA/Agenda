using Agenda03.RefServAgenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda03
{
    public partial class Form1 : Form
    {
        private SCAgendaClient agenda;
        public Form1()
        {
            InitializeComponent();
            agenda = new SCAgendaClient();
            listPersonas.DataSource = agenda.ObtenerPersonas();
        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var per = agenda.seleccionaPersona(((BEPersona)listPersonas.SelectedItem).codPersona);
            //txtcodigo.Value = per.codPersona;
            //txtNombre.Text = per.nombre;
            //txtApellidos.Text = per.apellidos;
            //txtDireccion.Text = per.direccion;
            //listTelefonos.DataSource = per.telefonos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //var bePer = new BEPersona();
            //bePer.codPersona = (int)txtcodigo.Value;
            //bePer.nombre = txtNombre.Text;
            //bePer.apellidos = txtApellidos.Text;
            //bePer.direccion = txtDireccion.Text;
            //bePer.telefonos = new List<BETelefono>();
            //if (!agenda.insertaPersona(bePer))
            //    MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            //    MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    listPersonas.DataSource = agenda.seleccionarPersonas();
            //}
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //var bePer = new BEPersona();
            //bePer.codPersona = (int)txtcodigo.Value;
            //bePer.nombre = txtNombre.Text;
            //bePer.apellidos = txtApellidos.Text;
            //bePer.direccion = txtDireccion.Text;
            //bePer.telefonos = new List<BETelefono>();
            //foreach (var item in (List<BETelefono>)listTelefonos.DataSource)
            //{
            //    bePer.telefonos.Add(item);
            //}
            //if (!agenda.actualizaPersona(bePer))
            //    MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //{
            //    MessageBox.Show("Actualizado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    listPersonas.DataSource = agenda.seleccionarPersonas();
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //var resultado = agenda.eliminarPersona((int)txtcodigo.Value);
            //if (!resultado)
            //{
            //    MessageBox.Show("No se pudo eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    listPersonas.DataSource = agenda.seleccionarPersonas();
            //}
        }
    }
}
