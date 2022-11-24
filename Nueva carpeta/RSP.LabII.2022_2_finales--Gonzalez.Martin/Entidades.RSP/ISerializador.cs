using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RSP
{
    public interface ISerializador<T>
    {
        public bool Escribir(string file, T contenido);






        public List<T> Leer(string archivo, Action<string> mostrarElementos);
    }
}
