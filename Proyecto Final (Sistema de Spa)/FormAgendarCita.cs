using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final__Sistema_de_Spa_
{
    public partial class FormAgendarCita : Form
    {
        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            cmbServicio.SelectedIndex = -1;
            textBoxDuracion.Text = "";
            txtTerapeuta.Text = "";
            txtEstado.Text = "";
            txtRestante.Text = "";
            textBoxID.Text = "";
        }
        private frmHome homeForm;
        public FormAgendarCita(frmHome home)

        {
            InitializeComponent();
            homeForm = home;
        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbServicio.SelectedItem == null)
                return;
            switch (cmbServicio.SelectedItem.ToString())
            {
                case "masaje":
                    textBoxDuracion.Text = "60";
                    break;
                case "facial":
                    textBoxDuracion.Text = "45";
                    break;
                case "manicura":
                    textBoxDuracion.Text = "30";
                    break;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txtNombreCliente.Text, @"^[a-zA-Z\s]+$") ||
        !Regex.IsMatch(txtTerapeuta.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("El nombre del cliente y del terapeuta solo deben contener letras.");
                return;
            }

            if (cmbServicio.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un servicio.");
                return;
            }

            var cita = new Cita();
            cita.ID = homeForm.siguienteID++;
            cita.NombreCliente = txtNombreCliente.Text.Trim();
            cita.FechaHora = dtpFecha.Value.Date + dtpHora.Value.TimeOfDay;
            cita.Servicio = cmbServicio.SelectedItem.ToString();
            cita.CalcularDuracion();
            textBoxDuracion.Text = cita.DuracionMinutos.ToString();
            cita.Terapeuta = txtTerapeuta.Text.Trim();

            textBoxID.Text = cita.ID.ToString();
            textBoxDuracion.Text = cita.DuracionMinutos.ToString();
            txtEstado.Text = cita.Estado;
            txtRestante.Text = cita.TiempoRestante.ToString(@"dd\.hh\:mm");

            homeForm.listaCitas.Add(cita);
            MessageBox.Show("Cita agendada con éxito.");
            
        }

        private void FormAgendarCita_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            int pos = tb.SelectionStart;

            string limpio = System.Text.RegularExpressions.Regex.Replace(tb.Text, @"[^a-zA-Z\s]", "");

            if (limpio != tb.Text)
            {
                tb.Text = limpio;
                tb.SelectionStart = pos > 0 ? pos - 1 : 0; 
            }
        }

        private void txtTerapeuta_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            int pos = tb.SelectionStart;

            string limpio = System.Text.RegularExpressions.Regex.Replace(tb.Text, @"[^a-zA-Z\s]", "");

            if (limpio != tb.Text)
            {
                tb.Text = limpio;
                tb.SelectionStart = pos > 0 ? pos - 1 : 0;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Listo para ingresar una nueva cita.", "Nueva Cita", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
