using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public interface IParlamentario
    {
        public bool Presentismo { get; set; }
        public bool AperturaSesion { set; }
        public EVoto Voto { get; set; }

        public void EmitirVoto();
    }
}
