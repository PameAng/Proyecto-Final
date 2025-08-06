using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final__Sistema_de_Spa_
{
    public class Cita
    {
        public int ID { get; set; }
        public string NombreCliente { get; set; }
        public DateTime FechaHora { get; set; }
        public string Servicio { get; set; }
        public int DuracionMinutos { get; set; }
        public string Terapeuta { get; set; }
        public TimeSpan TiempoRestante => FechaHora - DateTime.Now;
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

        public void CalcularDuracion()
        {
            switch (Servicio.ToLower())
            {
                case "masaje": DuracionMinutos = 60; break;
                case "facial": DuracionMinutos = 45; break;
                case "manicura": DuracionMinutos = 30; break;
                default: DuracionMinutos = 0; break;
            }
        }
    }
}

