using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RSP
{
    public class ArchivosException : Exception
    {

        public ArchivosException(Exception innerException) : base("Fallo al cargar o guardar el archivo", innerException)
        {

        }
    }
}
