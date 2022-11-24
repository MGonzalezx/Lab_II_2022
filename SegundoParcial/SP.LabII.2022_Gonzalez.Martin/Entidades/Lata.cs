using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.IO;

namespace EntidadesSP
{
     public delegate void Lata_EventoPrecio(bool booleano);
    public class Lata<T>where T: Articulo
    {

        public static event Lata_EventoPrecio EventoPrecio;

        

        protected int capacidad;

        protected List<T> elementos;


        protected List<T> Elementos { get { return this.elementos; } }

        public double PrecioTotal 
        { 
            get 
            {
                double aux = 0;
                foreach (var item in elementos)
                {
                    aux += item.Precio;
                }

                return aux;
            } 
        }

        public Lata()
        {
            elementos = new List<T>();
        }

        public Lata(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"Tipo de lata: {this} - Capacidad: {this.capacidad} - Cantidad actual de elementos: {elementos.Count} - Precio total: {this.PrecioTotal}");

            foreach (var item in elementos)
            {
                sr.AppendLine(item.ToString());
            }
            return sr.ToString();
        }

        public static Lata<T> operator +(Lata<T> l, T p)
        {

            if (l.elementos.Count < l.capacidad)
            {
                l.elementos.Add(p);

                if (l.PrecioTotal > 2000)
                {
                    if (EventoPrecio is not null)
                    {
                        EventoPrecio.Invoke(true);
                        //Facturadora<T>.ImprimirFactura(l);
                        //using (StreamWriter writer = new StreamWriter(GetFolderPath(SpecialFolder.MyDocuments) + "\\facturas.log", true))
                        //{
                        //    writer.WriteLine(DateTime.Now);
                        //    writer.WriteLine(l.PrecioTotal);
                        //}
                    }
                }

            }
            else
            {
                throw new LataLlenaException("La lata está llena");
            }

            



            return l;
        }
    }
}
