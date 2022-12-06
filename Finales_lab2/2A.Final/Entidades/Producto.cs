using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(ProdImpuesto))]
    public class Producto
    {
        protected string nombre;
        protected int cantidad;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public int Stock
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public Producto() { }

        public Producto(string nombre, int cantidad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
        }

        public static Boolean operator ==(Producto p1, Producto p2)
        {
            return p1.Nombre == p2.Nombre;
        }

        public static Boolean operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0} - Stock: {1}\n",this.nombre,this.cantidad);
        }
    }
}
