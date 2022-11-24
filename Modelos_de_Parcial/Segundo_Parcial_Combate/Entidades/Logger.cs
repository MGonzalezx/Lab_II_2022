using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Entidades
{
    public class Logger
    {
        private string ruta;


        public Logger(string ruta)
        {
            this.ruta = ruta;
        }
        public void GuardarLog(string texto)
        {
            //true para el append
            using(StreamWriter writer = new StreamWriter(ruta,true))
            {
                writer.WriteLine(texto);
            }
        }


    }
}
