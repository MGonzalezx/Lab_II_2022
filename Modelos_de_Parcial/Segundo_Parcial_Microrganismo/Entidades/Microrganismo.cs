using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades
{
    public class Microrganismo
    {
        public enum EContagiosidad
        {
            Baja,
            Moderada,
            Alta
        }

        public enum ETipo
        {
            Virus,
            Bacteria
        }

        protected long contador;
        private EContagiosidad contagiosidad;
        private string nombre;
        private ETipo tipo;

         public virtual long IndiceContagios { get; }
        public Microrganismo(string nombre)
        {
            this.nombre = nombre;
            this.contador = 1;
        }
        public Microrganismo( string nombre, ETipo tipo,EContagiosidad contagiosidad ) : this(nombre)
        {
            this.contagiosidad = contagiosidad;
            this.tipo = tipo;
        }

        public string Informe()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"El {this.tipo} lleva el nombre de {this.nombre} y tiene una contagiosidad {this.contagiosidad}. Su impacto de contagios se calcula en {this.IndiceContagios}.");

            return sr.ToString();
        }
       
    }
}
