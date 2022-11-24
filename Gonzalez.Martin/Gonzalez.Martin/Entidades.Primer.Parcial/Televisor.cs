using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Televisor : Producto
    {
        #region Atributos

        public ETipo tipo;
        #endregion


        #region Constructores

        public Televisor(string modelo, string marca, EPais pais, ETipo tipo) : base(modelo, marca, pais)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Sobrecargas

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Televisor)
            {
                retorno = ((Televisor)obj) == this;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.Append($"{((string)this)}");
           // sb.AppendLine($"MODELO: {base.modelo}");
            //sb.AppendLine($"PRECIO: {base.Precio}");
            sb.AppendLine($"TIPO: {this.tipo}");


            return sb.ToString();
        }

        public static explicit operator Double(Televisor tv)
        {
            return tv.Precio;
        }

        public static bool operator ==(Televisor a, Televisor b)
        {
            return (Producto)a == b && a.tipo == b.tipo;
        }

        public static bool operator !=(Televisor a, Televisor b)
        {
            return !(a == b);
        }
        #endregion
    }
}
