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
    public partial class FormMostrarCitas : Form
    {
        private List<Cita> listaCitas;
        public FormMostrarCitas(List<Cita> citas)
        {
            InitializeComponent();
            listaCitas = citas;
        }

        private void FormMostrarCitas_Load(object sender, EventArgs e)
        {
            dgvCitas.DataSource = listaCitas.Select(c => new
            {
                c.ID,
                c.NombreCliente,
                FechaHora = c.FechaHora.ToString("yyyy-MM-dd HH:mm"),
                c.Servicio,
                DuracionMinutos = c.DuracionMinutos, 
                c.Terapeuta,
                Estado = ObtenerEstado(c),
                TiempoRestante = ObtenerTiempoRestante(c)
            }).ToList();
        }

        private string ObtenerEstado(Cita c)
        {
            var ahora = DateTime.Now;
            if (c.FechaHora > ahora) return "Vigente";
            else if (ahora >= c.FechaHora && ahora <= c.FechaHora.AddMinutes(c.DuracionMinutos)) return "En proceso";
            else return "Finalizado";
        }

        private string ObtenerTiempoRestante(Cita c)
        {
            var diferencia = c.FechaHora - DateTime.Now;
            if (diferencia.TotalSeconds < 0) return "Ya pasó";
            return $"{(int)diferencia.TotalDays} días y {diferencia.Hours} horas";
        }
    }
}
   
