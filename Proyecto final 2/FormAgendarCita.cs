using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_2
{
    public partial class FormAgendarCita : Form
    {
        private List<Cita> citas;
        private int ultimoId;

        public FormAgendarCita(List<Cita> listaCitas, ref int idActual)
        {
            InitializeComponent();
            citas = listaCitas;
            ultimoId = idActual;
            txtId.Text = idActual.ToString();

        }

        private int CalcularDuracion(string servicio)
        {
            switch (servicio)
            {
                case "Masaje": return 60;  // 1 hora
                case "Facial": return 45;
                case "Manicura": return 30;
                default: return 30;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServicio.Items.AddRange(new string[] { "Masaje", "Facial", "Manicura" });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)
        || string.IsNullOrWhiteSpace(txtTelefono.Text)   
        || cmbServicio.SelectedIndex == -1)

            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            var nuevaCita = new Cita
            {
                Id = ultimoId,
                NombreCliente = txtNombre.Text,
                Servicio = cmbServicio.SelectedItem.ToString(),
                FechaHora = dtpFechaHora.Value,
                Terapeuta = txtTerapeuta.Text,
                DuracionMinutos = CalcularDuracion(cmbServicio.SelectedItem.ToString())
            };
            citas.Add(nuevaCita);
            MessageBox.Show("✅ Cita agendada correctamente");

            ultimoId++; // Incrementa para la próxima cita
            this.Close();


        }

        private void FormAgendarCita_Load(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquea el carácter
            }
        }

        private void txtTerapeuta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
