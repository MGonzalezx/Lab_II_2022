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
    public class ProdVendido : ProdExport
    {
        public string cliente;

        public ProdVendido() { }

        public ProdVendido(ProdExport pe, string cliente)
            : base(new ProdImpuesto(pe.Nombre,pe.Stock,pe.impuesto),pe.pais)
        {
            this.cliente = cliente;
        }

        public override string ToString()
        {
          return string.Format("{0} - Cliente: {1}\n", base.ToString(), this.cliente);
        }
    }
}
