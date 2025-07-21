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
    public partial class FormMostrarCitas : Form
    {
        private List<Cita> citas;
        public FormMostrarCitas(List<Cita> lista)
        {
            InitializeComponent();
            citas = lista;
        }

        private void dgvCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMostrarCitas_Load(object sender, EventArgs e)
        {
            CargarCitas();
        }
        private void CargarCitas()
        {
            dgvCitas.DataSource = null;

            dgvCitas.DataSource = citas.Select(c => new
            {
                c.Id,
                Cliente = c.NombreCliente,
                c.Servicio,
                Fecha = c.FechaHora.ToString("dd/MM/yyyy HH:mm"),
                c.Terapeuta,
                Duración = c.DuracionMinutos + " min",
                Restante = c.TiempoRestante.TotalMinutes > 0 ?
                           $"{c.TiempoRestante.Days}d {c.TiempoRestante.Hours}h {c.TiempoRestante.Minutes}m"
                           : "Ya pasó",
                Estado = c.Estado
            }).ToList();
        }
    }
}
