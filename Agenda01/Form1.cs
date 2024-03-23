using Agenda.be;
using Agenda.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda01
{
    public partial class Form1 : Form
    {
        private daPersona daPer;
        public Form1()
        {
            InitializeComponent();
            daPer = new daPersona();
            listPersonas.DataSource = daPer.seleccionarPersonas();
        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var per = daPer.seleccionaPersona(((bePersona)listPersonas.SelectedItem).codPersona);
            txtcodigo.Value = per.codPersona;
            txtNombre.Text = per.nombre;
            txtApellidos.Text = per.apellidos;
            txtDireccion.Text = per.direccion;
            listTelefonos.DataSource = per.telefonos;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
			// logica de negocio
			if (txtDireccion.Text == string.Empty)
                MessageBox.Show("No puedes registrar sin direccion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else
			{
				var bePer = new bePersona();
				bePer.codPersona = (int)txtcodigo.Value;
				bePer.nombre = txtNombre.Text;
				bePer.apellidos = txtApellidos.Text;
				bePer.direccion = txtDireccion.Text;
				bePer.telefonos = new List<beTelefono>();
				if (!daPer.insertaPersona(bePer))
					MessageBox.Show("No se pudo registrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					MessageBox.Show("Registrado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					listPersonas.DataSource = daPer.seleccionarPersonas();
				}
			}
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
			// logica de negocio
			if ((int)txtcodigo.Value == 3)
				MessageBox.Show("No se puede modificar a este contacto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				var bePer = new bePersona();
				bePer.codPersona = (int)txtcodigo.Value;
				bePer.nombre = txtNombre.Text;
				bePer.apellidos = txtApellidos.Text;
				bePer.direccion = txtDireccion.Text;
				bePer.telefonos = new List<beTelefono>();
				foreach (var item in (List<beTelefono>)listTelefonos.DataSource)
				{
					bePer.telefonos.Add(item);
				}
				if (!daPer.actualizaPersona(bePer))
					MessageBox.Show("No se pudo actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
				{
					MessageBox.Show("Actualizado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					listPersonas.DataSource = daPer.seleccionarPersonas();
				}
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
			//logica de negocio
			if ((int)txtcodigo.Value == 1)
				MessageBox.Show("No se puede eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				var per = daPer.eliminarPersona((int)txtcodigo.Value);
				MessageBox.Show("Eliminado Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				listPersonas.DataSource = daPer.seleccionarPersonas();
			}
        }
    }
}
