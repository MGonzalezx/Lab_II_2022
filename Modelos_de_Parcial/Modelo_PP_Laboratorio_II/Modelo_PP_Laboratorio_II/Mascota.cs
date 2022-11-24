using System;
using System.Text;

namespace Modelo_PP_Laboratorio_II
{
    public abstract class Mascota
    {
        #region Atributos
        private string nombre;
        private string raza;
        #endregion


        #region Propiedades

        public string Nombre { get { return this.nombre; } }

        public string Raza { get { return this.raza; } }
        #endregion

        #region Constructor

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        #endregion

        #region Métodos

        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($" {this.nombre}   -  {this.raza}");

            return sb.ToString();
        }

        protected abstract string Ficha();
        #endregion


        #region Sobrecargas

        public static bool operator ==(Mascota m1, Mascota m2)
        {
            return m1.nombre == m2.nombre && m1.raza == m2.raza;
        }

        public static bool operator !=(Mascota m1, Mascota m2)
        {
            return !(m1 == m2);
        }
        #endregion
    }
}
