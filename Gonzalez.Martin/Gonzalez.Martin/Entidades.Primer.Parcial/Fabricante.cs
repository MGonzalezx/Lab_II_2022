using System;
using System.Text;

namespace Entidades.Primer.Parcial
{
    public class Fabricante
    {
        #region Atributos

        private string marca;
        private EPais pais;
        #endregion

        #region Constructor

        public Fabricante(string marca, EPais pais)
        {
            this.marca = marca;
            this.pais = pais;
        }
        #endregion

        #region Sobrecargas

        public static  implicit operator String(Fabricante f)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append( $"FABRICANTE: {f.marca} - {f.pais}");

            return sb.ToString();
        }

        public static bool operator ==(Fabricante a, Fabricante b)
        {
            return a.marca == b.marca && a.pais == b.pais;
        }

        public static bool operator !=(Fabricante a, Fabricante b)
        {
            return !(a == b);
        }
        #endregion
    }
}
