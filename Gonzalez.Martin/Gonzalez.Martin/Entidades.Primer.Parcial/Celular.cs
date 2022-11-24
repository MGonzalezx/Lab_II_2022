using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Celular : Producto
    {
        #region Atributos

        public EGama gama;
        #endregion

        #region Constructor

        public Celular(string modelo, Fabricante fabricante, EGama gama) : base(modelo, fabricante)
        {
            this.gama = gama;
        }
        #endregion

        #region Sobrecargas


        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Celular)
            {
                retorno = ((Celular)obj) == this;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.Append($"{((string)this)}");
            //sb.AppendLine($"MODELO: {base.modelo}");
            //sb.AppendLine($"PRECIO: {base.Precio}");
            sb.AppendLine($"GAMA: {this.gama}");



            return sb.ToString();
        }

        public static implicit operator Double(Celular celu)
        {
            return celu.precio;
        }

        public static bool operator ==(Celular a, Celular b)
        {
            return (Producto)a == b && a.gama == b.gama;
        }

        public static bool operator !=(Celular a, Celular b)
        {
            return !(a == b);
        }
        #endregion
    }
}
