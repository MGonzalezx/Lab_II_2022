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
    [XmlInclude(typeof(ProdExport))]
    public class ProdImpuesto : Producto
    {
        public double impuesto;

        public ProdImpuesto() { }

        public ProdImpuesto(string nombre, int cantidad, double impuesto)
            : base(nombre, cantidad)
        {
            this.impuesto = impuesto;
        }

        public override string ToString()
        {
          return string.Format("{0} - Impuesto: {1}\n", base.ToString(), this.impuesto);
        }
    }
}
