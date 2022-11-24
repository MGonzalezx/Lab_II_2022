using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.IO;

namespace EntidadesSP
{
    public static class Facturadora<T> where T : Articulo
    {
       public static bool ImprimirFactura(Lata<T> miLata)
        {
            bool retorno = false;
            using (StreamWriter writer = new StreamWriter(GetFolderPath(SpecialFolder.MyDocuments) + "\\facturas.log", true))
            {
                writer.WriteLine(DateTime.Now);
                writer.WriteLine(miLata.PrecioTotal);
                retorno = true;
            }
            return retorno;
        }
    }
}
