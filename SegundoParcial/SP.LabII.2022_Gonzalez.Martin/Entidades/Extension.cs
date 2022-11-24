using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public static class Extension
    {
        public static string InformarNovedad(this LataLlenaException mensaje)
        {
            return "La lata está llena";
        }
    }
}
