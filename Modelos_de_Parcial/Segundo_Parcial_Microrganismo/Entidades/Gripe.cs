using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gripe : Microrganismo
    {
        public override long IndiceContagios { 
            get 
            {
                return contador *= 2;
            } 
        }


        public Gripe(string nombre, ETipo tipo, EContagiosidad contagiosidad) : base(nombre,tipo,contagiosidad)
        {

        }
    }
}
