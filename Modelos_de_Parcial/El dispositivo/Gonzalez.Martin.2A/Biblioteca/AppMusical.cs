using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;

        protected override int Tamanio {
            get {
                int tamanioCanciones = listaCanciones.Count * 2;

                return tamanioMb + tamanioCanciones;
            } 
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial) : this(nombre, sistemaOperativo, tamanioInicial, new List<string>())
        {

        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones) : base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones is null)
            {
                this.listaCanciones = new List<string>();
            }
            else
            {
                this.listaCanciones = listaCanciones;
            }
        }

        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ObtenerInformacionApp()}");
            sb.AppendLine($"{Environment.NewLine}Lista de canciones: ");

            foreach (string item in listaCanciones)
            {
                sb.AppendLine(item);
            }

            return sb.ToString();
        }
    }
}
