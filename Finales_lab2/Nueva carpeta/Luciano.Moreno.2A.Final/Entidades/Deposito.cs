using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    [Serializable]
    public class Deposito : IGuardarXML
    {
        public string nombre;
        public List<Producto> productos;
        public int capacidad;

        public Deposito()
            : this("ninguno", 3)
        {}
        public Deposito(string nombre, int capacidad)
        {
            this.productos = new List<Producto>();
            this.nombre = nombre;
            this.capacidad = capacidad;
        }

        public void Add(Producto p)
        {
            if(this.productos.Count() < this.capacidad)
                this.productos.Add(p);
        }

        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            Deposito aux = new Deposito("", d1.capacidad + d2.capacidad);

            foreach (Producto p1 in d1.productos)
            {
                aux.Add(new Producto(p1.Nombre, p1.Stock));
            }
            
            foreach (Producto p2 in d2.productos)
            {
                Boolean existe = false;
                foreach (Producto aux1 in aux.productos)
                {
                    if (aux1==p2)
                    {
                        aux1.Stock += p2.Stock;
                        existe = true;
                    }
                }
                if(existe==false)
                {
                    aux.Add(new Producto(p2.Nombre, p2.Stock));
                }
            }

            return aux.productos;
        }

        public bool SerializarXML()
        {
            try
            {
                //XmlTextWriter escribir = new XmlTextWriter(path, Encoding.UTF8);
                StreamWriter escribir = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "deposito.xml", false);
                XmlSerializer ser;
                ser = new XmlSerializer(typeof(Deposito));
                ser.Serialize(escribir, this);
                escribir.Close();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
