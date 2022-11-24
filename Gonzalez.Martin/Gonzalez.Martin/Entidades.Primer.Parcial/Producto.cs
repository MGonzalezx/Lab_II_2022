using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public abstract class Producto
    {
        #region Atributos

        protected Fabricante fabricante;
        protected static Random generadorDePrecios;
        protected string modelo;
        protected double precio;
        #endregion


        #region Propiedades

        public double Precio
        {
            get
            {
                if( this.precio == 0)
                {
                    //Producto.generadorDePrecios = new Random();
                    this.precio = generadorDePrecios.Next(10500,125000);
                }
                return this.precio;
            }
        }

        #endregion

        #region Constructores

        static Producto()
        {
            Producto.generadorDePrecios = new Random();
            
        }

        public Producto(string modelo, Fabricante fabricante) 
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
        }

        public Producto(string modelo, string marca, EPais pais) : this(modelo, new Fabricante(marca, pais))
        {
            
        }
        #endregion

        #region Metodos
        private static string Mostrar(Producto p)
        {
            StringBuilder sb = new StringBuilder();

           
            sb.AppendLine($"{((string)p.fabricante)}");
            sb.AppendLine($"MODELO: {p.modelo}");
            sb.AppendLine($"PRECIO: {p.Precio}");


            return sb.ToString();
        }
        #endregion

        #region Sobrecargas

        public static explicit operator String(Producto p)
        {
          
            return Producto.Mostrar(p);
           
        }

       

        public static bool operator ==(Producto a, Producto b)
        {
            return a.modelo == b.modelo && (Fabricante)a.fabricante == (Fabricante)b.fabricante;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }
        #endregion
    }
}
