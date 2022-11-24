using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Botellas
{
    public class Cerveza : Botella
    {
        #region Atributos

        public int medida;
        public TipoCerveza tipo;
        #endregion

        #region Propiedades

        public override double Ganancia { get { return  this.precio * 0.50; } }

        #endregion

        #region Constructores

        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo) : this(marca, precio, capacidad, tipo, capacidad/3 )
        {

        }

        public Cerveza(string marca, double precio, int capacidad, TipoCerveza tipo, int medida) : base(marca, precio, capacidad)
        {
            this.tipo = tipo;
            this.medida = medida;
        }
        #endregion

        #region Métodos
        protected override void ServirMedida()
        {
            this.contenido -= this.medida;
            if (this.contenido < this.medida)
            {
                this.contenido = 0;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.Append($"Botella de Cerveza: {this.tipo} - {base.ToString()}");



            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Cerveza)
            {
                retorno = ((Cerveza)obj) == this;
            }

            return retorno;
        }

        #endregion
        public static bool operator ==(Cerveza a, Cerveza b)
        {
            return ((Botella)a) == b && a.tipo == b.tipo;
        }

        public static bool operator !=(Cerveza a, Cerveza b)
        {
            return !(a == b);
        }

        

    }
}
