using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final_2
{
    public class Cita
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Servicio { get; set; }
        public DateTime FechaHora { get; set; }
        public string Terapeuta { get; set; }
        public int DuracionMinutos { get; set; }
        public string Telefono { get; set; }

        // Calcula cuánto falta para la cita
        public TimeSpan TiempoRestante => FechaHora - DateTime.Now;

        // Calcula estado según fecha
        public string Estado
        {
            get
            {
                if (DateTime.Now < FechaHora)
                    return "Vigente";
                else if (DateTime.Now >= FechaHora && DateTime.Now <= FechaHora.AddMinutes(DuracionMinutos))
                    return "En proceso";
                else
                    return "Finalizado";
            }
        }
    }
}
    