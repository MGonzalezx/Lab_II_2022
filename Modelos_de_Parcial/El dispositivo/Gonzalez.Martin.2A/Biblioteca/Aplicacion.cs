using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Biblioteca
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        public SistemaOperativo SistemaOperativo { get {return this.sistemaOperativo; } }
        protected abstract int Tamanio { get; }

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            int maximo = 0;
            Aplicacion aplicacionMasPesada = null;
            foreach (Aplicacion item in listaApp)
            {

                if (maximo < item.Tamanio)
                {
                    maximo = item.tamanioMb;
                    aplicacionMasPesada = item;
                    
                    
                }
               
            }
            return aplicacionMasPesada;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre} - Sistema Operativo: {this.sistemaOperativo} - Tamanio: {this.tamanioMb}");

            return sb.ToString();
        }

        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            bool esta = false;
            foreach (Aplicacion item in listaApp)
            {
                if (item.nombre == app.nombre)
                {
                    esta = true;
                    break;

                }
            }
            return esta;
        }

        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            bool retorno = false;
            if (listaApp != app )
            {
                listaApp.Add(app);
                retorno = true;
            }
            else
            {
                Console.WriteLine($"Ya esta {app} en la lista");
            }



            return retorno;
        }

        public override string ToString()
        {
            return this.nombre; 
        }
    }
}
