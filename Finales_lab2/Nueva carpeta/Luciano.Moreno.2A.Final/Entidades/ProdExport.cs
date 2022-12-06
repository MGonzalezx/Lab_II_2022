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
    [XmlInclude(typeof(ProdVendido))]
    public class ProdExport : ProdImpuesto
    {
        public string pais;

        public ProdExport() { }

        public ProdExport(ProdImpuesto pi, string pais)
            : base(pi.Nombre,pi.Stock,pi.impuesto)
        {
            this.pais = pais;
        }

        public override string ToString()
        {
          return string.Format("{0} - Pais: {1}\n", base.ToString(), this.pais);
        }
    }
}
