using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Botellas;

namespace Entidades.Establecimiento
{
    public class Bar
    {
        #region Atributos

        private List<Botella> botellas;
        private int capacidadMaximaBotellas;
        private string nombre;
        private double recaudacion;
        #endregion

        #region Propiedades

        public List<Botella> Botellas { get { return this.botellas; } }
        public string MostrarBar { get { return this.Mostrar(); } }
        #endregion

        #region Constructores

        public Bar() 
        {
            this.botellas = new List<Botella>();
            this.capacidadMaximaBotellas = 5;
            this.nombre = "Sin nombre";
            
        }

        public Bar(int capacidad) : this()
        {
            this.capacidadMaximaBotellas = capacidad;
        }
        public Bar(int capacidad, string nombre) : this(capacidad)
        {
            this.nombre = nombre;
        }
        #endregion

        #region Métodos
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("BAR:");
            sb.AppendLine($"Nombre: {this.nombre} - Botellas: {this.capacidadMaximaBotellas} - Recaudacion: {this.recaudacion}");
           
            foreach (Botella item in this.botellas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarBotellas(Ordenamiento o)
        {
            if(o == Ordenamiento.Marca)
            {
                this.botellas.Sort(OrdernarPorMarca);

            }else if(o == Ordenamiento.Ganancia)
            {
                this.botellas.Sort(OrdenarPorGanancia);
            }
            else if (o == Ordenamiento.PorcentajeContenido)
            {
                this.botellas.Sort(OrdenarPorContenido);
            }
        }

        private static int OrdenarPorContenido(Botella a, Botella b)
        {
            int retorno;
            retorno = b.PorcentajeContenido.CompareTo(a.PorcentajeContenido);
            return retorno;
        }

        private int OrdenarPorGanancia(Botella a, Botella b)
        {
            int retorno;
            retorno = b.Ganancia.CompareTo(a.Ganancia);
            return retorno;
        }

        private static int OrdernarPorMarca(Botella a, Botella b)
        {
            int retorno;
            retorno = ((string)b).CompareTo(((string)a));
            return retorno;
        }

        #endregion

        #region Sobrecargas

        public static explicit operator Double(Bar b)
        {
            return b.recaudacion;
        }


        public static bool operator ==(Bar a, Botella b)
        {
            bool esta = false;
            foreach (Botella item in a.botellas)
            {
                if (item.Equals(b))
                {
                    esta = true;
                    break;

                }
            }
            return esta;
        }

        public static bool operator !=(Bar a, Botella b)
        {
            return !(a==b);
        }

        public static Bar operator -(Bar a, Botella b)
        {
            if (a == b)
            {
                b--;
                a += b.Ganancia;

                if (b.PorcentajeContenido == 0)
                {
                    a.botellas.Remove(b);
                }
            }
            else
            {
                Console.WriteLine($"No esta el {b} en el grupo");
            }
            return a;
        }

        public static Bar operator +(Bar a, Botella b)
        {
            if (a != b && a.botellas.Count < a.capacidadMaximaBotellas)
            {
                a.botellas.Add(b);

            }
            else
            {
                Console.WriteLine($"Ya esta {b} en la lista"); 
            }



            return a;
        }

        public static Bar operator +(Bar a, double g)
        {

            a.recaudacion += g;

            return a;
        }
        #endregion

       
    }
}
