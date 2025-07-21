using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;



namespace Proyecto_final_2
{
    public partial class Form1 : Form
    {
        // Lista global de citas
        private List<Cita> citas = new List<Cita>();
        private int ultimoId = 1; // Para generar IDs únicos
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgendarCita form = new FormAgendarCita(citas, ref ultimoId);
            form.ShowDialog();

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (citas.Count == 0)
            {
                MessageBox.Show("No hay citas registradas.");
                return;
            }

            FormMostrarCitas form = new FormMostrarCitas(citas);
            form.ShowDialog();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (citas.Count == 0)
            {
                MessageBox.Show("No hay citas registradas para actualizar.");
                return;
            }

            // Mostrar IDs disponibles
            string idsDisponibles = string.Join(", ", citas.Select(c => c.Id));
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"IDs disponibles: {idsDisponibles}\n\nIngrese el ID de la cita que desea actualizar:",
                "Actualizar Cita", "");

            if (!int.TryParse(input, out int idActualizar))
            {
                MessageBox.Show("Debe ingresar un número de ID válido.");
                return;
            }

            // Buscar la cita correspondiente
            Cita citaEncontrada = citas.FirstOrDefault(c => c.Id == idActualizar);

            if (citaEncontrada == null)
            {
                MessageBox.Show("No se encontró una cita con ese ID.");
                return;
            }

            // Pedir nuevos datos
            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el nuevo nombre del cliente:",
                "Actualizar Cita", citaEncontrada.NombreCliente);

            string nuevoServicio = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el nuevo servicio:",
                "Actualizar Cita", citaEncontrada.Servicio);

            string nuevoTelefono = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el nuevo teléfono:",
                "Actualizar Cita", citaEncontrada.Telefono);

            string nuevaFechaTexto = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese la nueva fecha y hora (ej: 2025-07-20 15:30):",
                "Actualizar Cita", citaEncontrada.FechaHora.ToString());

            if (!DateTime.TryParse(nuevaFechaTexto, out DateTime nuevaFechaHora))
            {
                MessageBox.Show("Formato de fecha y hora inválido. No se actualizó la cita.");
                return;
            }

            // Actualizar los datos
            citaEncontrada.NombreCliente = nuevoNombre;
            citaEncontrada.Servicio = nuevoServicio;
            citaEncontrada.Telefono = nuevoTelefono;
            citaEncontrada.FechaHora = nuevaFechaHora;

            MessageBox.Show("✅ Cita actualizada correctamente.");
        }
        

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (citas.Count == 0)
            {
                MessageBox.Show("No hay citas registradas.");
                return;
            }

            // Mostramos los IDs disponibles como referencia
            string idsDisponibles = string.Join(", ", citas.Select(c => c.Id));

            // Pedimos el ID al usuario
            string input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Citas registradas con ID: {idsDisponibles}\n\nIngrese el ID de la cita que desea eliminar:",
                "Eliminar Cita",
                "");

            // Validar que sea número
            if (int.TryParse(input, out int id))
            {
                var citaEliminar = citas.FirstOrDefault(c => c.Id == id);

                if (citaEliminar != null)
                {
                    // Confirmar antes de borrar
                    DialogResult confirm = MessageBox.Show(
                        $"¿Está seguro de eliminar la cita con ID {id}?\nCliente: {citaEliminar.NombreCliente}\nServicio: {citaEliminar.Servicio}",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        citas.Remove(citaEliminar);
                        MessageBox.Show($"✅ Cita con ID {id} eliminada correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("⚠ No se encontró ninguna cita con ese ID.");
                }
            }
            else
            {
                MessageBox.Show("⚠ ID inválido.");
            }
        }
        

        private void exportarACSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (citas.Count == 0)
            {
                MessageBox.Show("No hay citas para exportar.");
                return;
            }

            // Ventana para elegir dónde guardar el archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar citas como CSV";
            saveFileDialog.FileName = "CitasSpa.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Construimos el contenido CSV
                    StringBuilder csvContent = new StringBuilder();

                    // Encabezado
                    csvContent.AppendLine("ID,NombreCliente,Servicio,Telefono,FechaHora");

                    // Filas
                    foreach (var cita in citas)
                    {
                        string linea = $"{cita.Id}," +
                                       $"{cita.NombreCliente}," +
                                       $"{cita.Servicio}," +
                                       $"{cita.Telefono}," +
                                       $"{cita.FechaHora}";
                        csvContent.AppendLine(linea);
                    }

                    // Guardar en archivo
                    System.IO.File.WriteAllText(saveFileDialog.FileName, csvContent.ToString(), Encoding.UTF8);

                    MessageBox.Show("✅ Citas exportadas correctamente.", "Exportar CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al exportar: " + ex.Message);
                }
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
