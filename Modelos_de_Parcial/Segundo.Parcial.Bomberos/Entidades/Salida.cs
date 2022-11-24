using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entidades
{
    public class Salida
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }

        public double TiempoTotal { get => fechaInicio.CalcularDiferenciaEnSegundos(fechaFin);}


        public Salida()
        {
            fechaInicio = DateTime.Now;
        }

        public void FinalizarSalida()
        {
            fechaFin = DateTime.Now;
        }

        
    }
}
