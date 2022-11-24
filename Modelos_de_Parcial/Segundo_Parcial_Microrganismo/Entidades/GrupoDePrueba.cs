using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public delegate void AvanceInfectados(int dia, long infectados);
    public delegate void FinInfectacion();

    public static class GrupoDePrueba <T> where T : Microrganismo
    {

        public static event AvanceInfectados InformeDeAvance;

        public static event FinInfectacion FinalizaSimulacion;

        

        private static T enfermedad;
        private static long poblacion;

        public static long Poblacion { get => poblacion; set => poblacion = value; }

         static GrupoDePrueba()
        {
            poblacion = 10000000;
        }

        public static void InfectarProblacion(object obj)
        {
            T microrganismo = obj as T;
            int dia = 0;
            long infectados = 0;
            if (microrganismo is not null)
            {
                enfermedad = microrganismo;
                dia = 1;
                do
                {
                    infectados = enfermedad.IndiceContagios;
                    if (InformeDeAvance is not null)
                    {
                        InformeDeAvance.Invoke(dia, infectados);
                        dia++;
                        Thread.Sleep(750);
                    }

                }
                while (infectados <= poblacion);

                if (FinalizaSimulacion is not null)
                {

                    FinalizaSimulacion.Invoke();    

                }
            }
        }
    }
}
