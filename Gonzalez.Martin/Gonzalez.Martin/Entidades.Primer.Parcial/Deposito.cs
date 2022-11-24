using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Primer.Parcial
{
    public class Deposito
    {
        #region Atributos

        private int capacidad;
        private List<Producto> productos;
        #endregion

        #region Propiedades

        public double PrecioDeCelulares 
        {
            get 
            {
                return this.ObtenerPrecio(EProducto.PrecioDeCelulares);
            } 
        }
        public double PrecioDeTelevisores 
        { 
            get 
            {
                return this.ObtenerPrecio(EProducto.PrecioDeTelevisores);
            } 
        }
        public double PrecioTotal 
        { 
            get 
            {
                return this.ObtenerPrecio(EProducto.PrecioTotal);
            } 
        }
        #endregion

        #region Constructores

        private Deposito()
        {
            productos = new List<Producto>();
        }
        private Deposito(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        

        #region Metodos

        public static string Mostrar(Deposito d)
        {
            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine($"CAPACIDAD: {d.capacidad}");
            sb.AppendLine($"Total por Televisores: {d.PrecioDeTelevisores}");
            sb.AppendLine($"Total por Celulares: {d.PrecioDeCelulares}");
            sb.AppendLine($"Total: {d.PrecioTotal}");

            sb.AppendLine($"****************************************");
            sb.AppendLine($"LISTADO");
            sb.AppendLine($"****************************************");

            foreach (Producto item in d.productos)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static implicit operator Deposito(int capacidad)
        {
            
            Deposito miDeposito = new Deposito(capacidad);
           
            return miDeposito;
        }
        private double ObtenerPrecio(EProducto tipoProducto)
        {
            double retorno = 0;

            
            if(tipoProducto == EProducto.PrecioDeCelulares)
            {
                foreach (Producto item in this.productos)
                {
                    if(item is Celular)
                    {
                        retorno += item.Precio;
                    }
                }
            }

            else if (tipoProducto == EProducto.PrecioDeTelevisores)
            {
                foreach (Producto item in this.productos)
                {
                    if (item is Televisor)
                    {
                        retorno += item.Precio;
                    }
                }
            }
            else
            {
                foreach (Producto item in this.productos)
                {
                   
                    
                        retorno += item.Precio;
                    
                }
            }



            return retorno;
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            bool esta = false;
            foreach (Producto item in d.productos)
            {
                if (item.Equals(p))
                {
                    esta = true;
                    break;

                }
            }
            return esta;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static Deposito operator +(Deposito d, Producto p)
        {

            if (d != p && d.productos.Count < d.capacidad)
            {
                d.productos.Add(p);

            }
            
            else
            {
                Console.WriteLine($"El producto ya se encuentra en el deposito!!!!");
            }



            return d;
        }

        #endregion

    }
}
