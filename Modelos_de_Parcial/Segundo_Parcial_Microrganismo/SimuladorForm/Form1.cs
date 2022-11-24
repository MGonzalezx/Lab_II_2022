using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SimuladorForm
{
    public partial class Form1 : Form
    {
        Task hilo;
        Microrganismo microrganismo;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GrupoDePrueba<Microrganismo>.InformeDeAvance += Informe;
            GrupoDePrueba<Microrganismo>.FinalizaSimulacion += Final;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            microrganismo = new Covid19("Covid");
            Ejecutar<Microrganismo>(microrganismo);
        }

        private void Ejecutar<T>(T enfermedad) where T :class
        {
            hilo = new Task(() => { GrupoDePrueba<Microrganismo>.InfectarProblacion(enfermedad); });

            hilo.Start();
            
        }

        private void Final()
        {
            if (this.InvokeRequired)
            {
                Action delegado = Final;
                Invoke(delegado);
            }
            else
            {
                txtEvolucion.Text += $"Toda la población fue infectada";


            }
        }

        private void Informe(int dia, long infectados)
        {
            if (this.InvokeRequired)
            {
                Action<int,long> delegado = Informe;
                this.Invoke(delegado, new object[] { dia, infectados });
            }
            else
            {
                txtEvolucion.Text += $"Dia: {dia} Infectados: {infectados} \n";

                
            }
        }

    }
}
