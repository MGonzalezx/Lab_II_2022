using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cosa<T>
    {
        public List<String> listado;

        public Cosa()
        {
            this.listado = new List<string>();
        }

        public void Add(T datos)
        {
            this.listado.Add(datos.ToString());
        }

        public void Remove(T datos)
        {
            this.listado.Remove(datos.ToString());
        }

        public string Count
        {
            get
            {
                string retorno = "";

                foreach (String s in listado)
                {
                    retorno += s + " ";
                }

                return retorno;
            }
        }

    }
}
