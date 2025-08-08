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
    public partial class FormActualizarCita : Form
    {
        private List<Cita> listaCitas;
        private Cita citaActual;
        public FormActualizarCita(List<Cita> citas)
        {
            InitializeComponent();
            listaCitas = citas;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpHora.Format = DateTimePickerFormat.Time;
            dtpHora.ShowUpDown = true;
        }

        private void FormActualizarCita_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int id))
            {
                citaActual = listaCitas.FirstOrDefault(c => c.ID == id);
                if (citaActual != null)
                {
                    txtNombre.Text = citaActual.NombreCliente;
                    dtpFecha.Value = citaActual.FechaHora.Date;
                    dtpHora.Value = DateTime.Today.Add(citaActual.FechaHora.TimeOfDay);
                    txtServicio.Text = citaActual.Servicio;
                    txtTerapeuta.Text = citaActual.Terapeuta;
                }
                else
                {
                    MessageBox.Show("Cita no encontrada.");
                }
            }
            else
            {
                MessageBox.Show("ID inválido.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (citaActual != null)
            {
                citaActual.NombreCliente = txtNombre.Text;

                
                DateTime fecha = dtpFecha.Value.Date;
                TimeSpan hora = dtpHora.Value.TimeOfDay;
                citaActual.FechaHora = fecha + hora;

                citaActual.Servicio = txtServicio.Text;
                citaActual.Terapeuta = txtTerapeuta.Text;
                citaActual.CalcularDuracion();

                MessageBox.Show("Cita actualizada correctamente.");

                LimpiarCampos(); 

                citaActual = null;


            }
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtNombre.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtServicio.SelectedIndex = -1;
            txtTerapeuta.Clear();
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
