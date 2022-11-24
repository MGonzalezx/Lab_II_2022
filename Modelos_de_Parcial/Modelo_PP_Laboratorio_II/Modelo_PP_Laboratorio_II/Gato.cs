using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PP_Laboratorio_II
{
    public class Gato : Mascota
    {

        #region Constructor

        public Gato(string nombre, string raza) : base(nombre, raza)
        {

        }
        #endregion

        #region Métodos

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Gato)
            {
                retorno = ((Gato)obj) == this; 
            }

            return retorno;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            
            
                sb.Append($"gato - {base.DatosCompletos()} ");
                //sb.Append(base.DatosCompletos());
              

            return sb.ToString();
        }
        public override string ToString()
        {
                return this.Ficha();
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Gato g1, Gato g2) 
        {
            return ((Mascota)g1) == g2;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        #endregion

       
    }
}
