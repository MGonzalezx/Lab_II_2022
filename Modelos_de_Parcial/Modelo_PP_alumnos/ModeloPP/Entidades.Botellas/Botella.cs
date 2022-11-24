using System;
using System.Text;

namespace Entidades.Botellas
{
    public abstract class Botella
    {
        #region Atributos

        protected int capacidad;
        protected int contenido;
        protected string marca;
        protected double precio;
        #endregion

        #region Propiedades

        public abstract double Ganancia{ get ; }

        public double PorcentajeContenido { get { return ((this.contenido*100) / this.capacidad) ; } }
        #endregion

        #region Constructores

        public Botella(string marca, double precio) : this(marca, precio, 1000)
        {

        }
        public Botella(string marca, double precio, int capacidad)
        {
            this.marca = marca;
            this.precio = precio;
            this.capacidad = capacidad;
            this.contenido = capacidad;
        }
        #endregion


        #region Métodos
        protected abstract void ServirMedida();
       

        private static string ObetenerDatos(Botella b)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($" Marca: {b.marca} - Precio: {b.precio} - Contenido: {b.PorcentajeContenido} % - Capacidad: {b.capacidad} - Ganancia: {b.Ganancia}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return Botella.ObetenerDatos(this);
        }

        #endregion

        #region Sobrecargas

        public static explicit operator  String (Botella b)
        {
            return b.marca;
        }

        public static bool operator ==(Botella a, Botella b)
        {
            return a.marca == b.marca && a.capacidad == b.capacidad;
        }

        public static bool operator !=(Botella a, Botella b)
        {
            return !(a == b);
        }


        public static Botella operator --(Botella a)
        {
            a.ServirMedida();

            return a;
        } 
        #endregion

        

    }
}
