using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Threading;

namespace Entidades

{   public delegate void FinDeSalida(int bomberoIndex);
    public class Bombero : IArchivo<Bombero> , IArchivo<string>
    {
      

        public event FinDeSalida MarcarFin;
        private string nombre;
        private List<Salida> salidas;
        private static string rutaArchivo;
        private static Random random;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public List<Salida> Salidas
        {
            get
            {
                return salidas;
            }
            set
            {
                salidas = value;
            }
        }

        static Bombero()
        {
            rutaArchivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Bombero.xml");
            random = new Random();
        }

        public Bombero(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Bombero()
        {
            salidas = new List<Salida>();
        }

        public void AtenderSalida(int bomberoIndex)
        {
            //1
            Salida salida = new Salida();
            this.salidas.Add(salida);

            //2
            Thread.Sleep(random.Next(2000, 4000));

            //3
            salida.FinalizarSalida();

            //4
            string log = $"Salida finalizada. Inicio: {salida.FechaInicio.ToLongTimeString()}. " +
               $"Fin: {salida.FechaFin.ToLongTimeString()}. Duración: {salida.TiempoTotal} segundos.";
            ((IArchivo<string>)this).Guardar(log);

            //5
            MarcarFin(bomberoIndex);
        }

        /// PARA IArchivo<Bombero>
       public void Guardar(Bombero info)
        {
            using StreamWriter streamWriter = new StreamWriter(rutaArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
            xmlSerializer.Serialize(streamWriter, info);
        }

        public Bombero Leer()
        {
            using StreamReader streamReader = new StreamReader(rutaArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Bombero));
            return (Bombero)xmlSerializer.Deserialize(streamReader);
        }


        /// PARA IArchivo<string>
        void IArchivo<string>.Guardar(string info)
        {
            LogDAO log = new LogDAO();
            log.Guardar(info);
        }

        string IArchivo<string>.Leer()
        {
            LogDAO log = new LogDAO();
            return log.Leer();
        }

    }
}
