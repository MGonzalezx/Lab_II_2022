using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        public int _cantidad;
        public event EventHandler EsImpar;

        public Numero()
        {

        }

        public Numero(int cantidad)
        {
            this.Cantidad = cantidad;
        }

        public int Cantidad
        {
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("El valor que se intenta asignar es 0");
                }
                else if (value.EsPar())
                {
                    this._cantidad = value;
                }
                else if (value.EsImpar())
                {
                    this._cantidad = value;
                    this.EsImpar(this, new EventArgs());
                }
            }
        }

    }
}
