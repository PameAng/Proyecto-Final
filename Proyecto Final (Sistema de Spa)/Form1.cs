using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Proyecto_Final__Sistema_de_Spa_
{
    public partial class frmHome : Form
    {
        public List<Cita> listaCitas = new List<Cita>();
        public int siguienteID = 1;

        private List<Image> imagenesSlideshow;
        private int indiceActual = 0;
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            imagenesSlideshow = new List<Image>()
    {
        Properties.Resources.SpaFondo1,  // Asegúrate que estos nombres coincidan con tus imágenes
        Properties.Resources.SpaFondo2,
        Properties.Resources.SpaFondo3
    };

            pictureBoxSlideshow.Image = imagenesSlideshow[indiceActual];
            pictureBoxSlideshow.Visible = true;

            timerSlideshow.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese el ID de la cita:", "Exportar a CSV");
            if (!int.TryParse(input, out int id)) return;

            var cita = listaCitas.FirstOrDefault(c => c.ID == id);
            if (cita == null)
            {
                MessageBox.Show("Cita no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV (*.csv)|*.csv",
                FileName = $"Cita_{id}.csv"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveDialog.FileName,
                    "ID,NombreCliente,FechaHora,Servicio,DuracionMinutos,Terapeuta,Estado,TiempoRestante\n" +
                    $"{cita.ID},{cita.NombreCliente},{cita.FechaHora:yyyy-MM-dd HH:mm},{cita.Servicio},{cita.DuracionMinutos},{cita.Terapeuta},{cita.Estado},{cita.TiempoRestante}");

                MessageBox.Show("Cita exportada con éxito.", "Exportado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // limpia el panel

            FormMostrarCitas formMostrar = new FormMostrarCitas(listaCitas);
            formMostrar.TopLevel = false;
            formMostrar.FormBorderStyle = FormBorderStyle.None;
            formMostrar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formMostrar);
            formMostrar.Show();
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            FormAgendarCita formAgendar = new FormAgendarCita(this);
            formAgendar.TopLevel = false;
            formAgendar.FormBorderStyle = FormBorderStyle.None;
            formAgendar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formAgendar);
            formAgendar.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
       "¿Está seguro que desea salir?",
       "Confirmación de salida",
       MessageBoxButtons.YesNo,
       MessageBoxIcon.Question
   );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit(); 
            }
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();

            FormActualizarCita formActualizar = new FormActualizarCita(listaCitas);
            formActualizar.TopLevel = false;
            formActualizar.FormBorderStyle = FormBorderStyle.None;
            formActualizar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formActualizar);
            formActualizar.Show();
        }

        private void BtnElimninar_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear(); // Limpia el panel antes de mostrar otro formulario

            FormEliminarCita formEliminar = new FormEliminarCita(listaCitas);
            formEliminar.TopLevel = false;
            formEliminar.FormBorderStyle = FormBorderStyle.None;
            formEliminar.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formEliminar);
            formEliminar.Show();
        }
        private void AbrirFormularioEnPanel(Form formulario)
        {
            pictureBoxSlideshow.Visible = false;
            timerSlideshow.Stop();

            panelContenedor.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxSlideshow_Click(object sender, EventArgs e)
        {

        }

        private void timerSlideshow_Tick(object sender, EventArgs e)
        {
            indiceActual++;
            if (indiceActual >= imagenesSlideshow.Count)
                indiceActual = 0;

            pictureBoxSlideshow.Image = imagenesSlideshow[indiceActual];
        }
    }
    }

