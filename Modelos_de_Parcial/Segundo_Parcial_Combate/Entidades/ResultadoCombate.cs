﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ResultadoCombate
    {
        private DateTime fechaCombate;
        private string nombreGanador;
        private string nombrePerdedor;


        public DateTime FechaCombate { get => fechaCombate; set => fechaCombate = value; }
        public string NombreGanador { get => nombreGanador; set => nombreGanador = value; }
        public string NombrePerdedor { get => nombrePerdedor; set => nombrePerdedor = value; }
        public ResultadoCombate( string nombreGanador, string nombrePerdedor, DateTime fechaCombate)
        {
            this.fechaCombate = fechaCombate;
            this.nombreGanador = nombreGanador;
            this.nombrePerdedor = nombrePerdedor;
        }


    }
}
