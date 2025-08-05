using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final__Sistema_de_Spa_
{
    public partial class FormEliminarCita : Form
    {
        private List<Cita> citas; 
        private Cita citaSeleccionada;
        public FormEliminarCita(List<Cita> listaCitas)

        {
            InitializeComponent();
            citas = listaCitas;
            grpDetalles.Enabled = false;

        }

        private void FormEliminarCita_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int idBuscado))
            {
                citaSeleccionada = citas.FirstOrDefault(c => c.ID == idBuscado);
                if (citaSeleccionada != null)
                {
                    lblCliente.Text = "Cliente: " + citaSeleccionada.NombreCliente;
                    lblServicio.Text = "Servicio: " + citaSeleccionada.Servicio;
                    lblFecha.Text = "Fecha: " + citaSeleccionada.FechaHora.ToString("dd/MM/yyyy HH:mm");
                    grpDetalles.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se encontró una cita con ese ID.");
                    grpDetalles.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (citaSeleccionada != null)
            {
                var confirm = MessageBox.Show("¿Deseas eliminar esta cita?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    citas.Remove(citaSeleccionada);
                    MessageBox.Show("Cita eliminada.");
                    this.Close(); 
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpDetalles_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
