using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesSP
{
    public class Cerveza : Articulo
    {
        public Cerveza(string marca, int codigo, double precio) : base(marca, codigo, precio)
        {
        }
    }
}
