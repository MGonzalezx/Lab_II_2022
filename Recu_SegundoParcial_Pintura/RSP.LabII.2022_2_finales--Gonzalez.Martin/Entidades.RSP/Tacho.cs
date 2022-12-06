using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades.RSP
{
    public class Tacho<T>
    {
        protected Int32 capacidad;
        protected List<T> items;
        public event Action<object, EventArgs> CapacidadCompleta;
        public event Action<object, EventArgs> ElementoRepetido;

        public List<T> Items
        {
            get
            {
                return this.items;
            }
        }

        private Tacho(int capacidad)
        {
            this.capacidad = capacidad;
            this.items = new List<T>();
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"CAPACIDAD: {this.capacidad} - ELEMENTOS: {this.items.Count}");

            foreach (T item in this.items)
            {
                sr.AppendLine($"ELEMENTO: {item}");
            }

            return sr.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is T)
            {
                retorno = (obj) == this;
            }

            return retorno;
        }

        public static implicit operator Tacho<T>(Int32 capacidad)
        {
            Tacho<T> miTacho = new Tacho<T>(capacidad);
            return miTacho;
        }
        public static bool operator ==(Tacho<T> p1, T p2)
        {
            bool retorno = false;
            foreach (T item in p1.items)
            {
                if (item.Equals(p2))
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Tacho<T> p1, T p2)
        {
            return !(p1 == p2);
        }

        public static Tacho<T> operator +(Tacho<T> p1, T p2)
        {

            if (p1 != p2 && p1.items.Count < p1.capacidad)
            {
                p1.items.Add(p2);

            }
            else if (p1 == p2)
            {
                p1.ElementoRepetido.Invoke(p2, EventArgs.Empty);
            }
            else if (p1.items.Count >= p1.capacidad)
            {
                p1.CapacidadCompleta.Invoke(p2, EventArgs.Empty);
            }


            return p1;
        }
    }
}
