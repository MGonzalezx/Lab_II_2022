using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extension
    {
        public static bool EsPar(this Int32 numero)
        {
            bool retorno = false;

            if (numero % 2 == 0) { retorno = true; }

            return retorno;
        }

        public static bool EsImpar(this Int32 numero)
        {
            return !(EsPar(numero));
        }

      
    }
}
