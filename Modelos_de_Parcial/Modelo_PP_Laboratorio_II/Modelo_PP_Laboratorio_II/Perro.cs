using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PP_Laboratorio_II
{
    public class Perro : Mascota
    {
        #region Atributos

        private int edad;
        private bool esAlfa;
        #endregion

        #region Constructores

        public Perro(string nombre, string raza) :  this(nombre, raza, 0, false)
        {
            
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre,raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Metodos

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"perro - {base.DatosCompletos()}");
            if (this.esAlfa)
            {
                sb.Append($", alfa de la manada, edad {this.edad}");
            }
            else
            {
                sb.Append($", edad {this.edad}");
            }
           

            //if (this.esAlfa)
            //{
            //    sb.Append("perro - ");
            //    sb.Append(base.DatosCompletos());
            //    sb.Append(" alfa de la manada, edad ");
            //    sb.AppendLine(this.edad.ToString());
            //}
            //else
            //{
            //    sb.Append($"perro - " + base.DatosCompletos());
            //   // sb.Append("perro - ");
            //    //sb.Append(base.DatosCompletos());
            //    sb.Append(", edad ");
            //    sb.AppendLine(this.edad.ToString());
            //}

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {

            bool retorno = false;
            if (!(obj == null) && obj is Perro)
            {
                retorno = ((Perro)obj) == this; 
            }

            return retorno;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

        #region Sobrecargas

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }


        public static bool operator ==(Perro p1, Perro p2)
        {
            return ((Mascota)p1) == p2 && p1.edad == p2.edad;
        }

        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        #endregion

    }
}
