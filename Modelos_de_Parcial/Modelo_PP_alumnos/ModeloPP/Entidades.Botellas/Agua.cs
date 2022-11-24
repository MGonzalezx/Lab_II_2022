using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Agua : Botella
    {
        #region Atributos

        public TipoAgua tipo;

        #endregion

        #region Propiedades

        public override double Ganancia { get { return this.precio += this.precio * 0.25; } }
        #endregion

        #region Constructores

        public Agua(string marca, double precio, int capacidad, TipoAgua tipo) : base(marca, precio, capacidad)
        {
            this.tipo = tipo;
        }

        public Agua(string marca, double precio, TipoAgua tipo) : this(marca,precio, 500, tipo)
        {

        }
        #endregion


        #region Métodos
        protected override void ServirMedida()
        {
            this.contenido -= this.contenido;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.Append($"Botella de Agua: {this.tipo} - {base.ToString()}");
           


            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Agua)
            {
                retorno = ((Agua)obj) == this;
            }

            return retorno;
        }
        #endregion


        #region Sobrecargas

        public static bool operator ==(Agua a, Agua b)
        {
            return ((Botella)a) == b && a.tipo == b.tipo;
        }

        public static bool operator !=(Agua a, Agua b)
        {
            return !(a==b);
        }
        #endregion

       
        

    }
}
