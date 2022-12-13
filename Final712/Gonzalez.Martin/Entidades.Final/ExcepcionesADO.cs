using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class ExcepcionesADO : Exception
    {
        public ExcepcionesADO(Exception innerException) : base("Fallo en la base de datos", innerException)
        {

        }
    }
}
