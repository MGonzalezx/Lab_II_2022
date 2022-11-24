using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Text.Json;

namespace Entidades.RSP
{
    public class Pasajero : ISerializador<Pasajero>
    {
        
        public Int32 dni;
        public string nombre;
        public Int32 equipaje;


        public Pasajero()
        {

        }

        public Pasajero(int dni, string nombre, int equipaje)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.equipaje = equipaje;
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"DNI: {this.dni} - NOMBRE: {this.nombre} - EQUIPAJE: {this.equipaje}");

            

            return sr.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Pasajero)
            {
                retorno = ((Pasajero)obj) == this;
            }

            return retorno;
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            bool retorno = false;
            if(p1.dni == p2.dni)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }


        public bool Escribir(string file, Pasajero info)
        {
            bool retorno = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    string json = JsonSerializer.Serialize(info);
                    writer.WriteLine(json);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
        }



        public List<Pasajero> Leer(string archivo, Action<string> mostrarElementos)
        {

            List<Pasajero> miLista = default;
            

            try
            {
                if (!string.IsNullOrEmpty(archivo))
                {
                    miLista = JsonSerializer.Deserialize<List<Pasajero>>(File.ReadAllText(archivo));
                    mostrarElementos("Documento deserializado con exito");
                }
                else
                {
                    throw new DirectoryNotFoundException("no encontrado");
                }

                return miLista;
            }
            
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
