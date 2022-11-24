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
    public class Carga : ISerializador<Carga>
    {
        ///Carga
        ///atributos públicos: codigo : Int32, tipo : String y peso : Double

        public Int32 codigo;
        public string tipo;
        public double peso;


        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"CÓDIGO: {this.codigo} - TIPO: {this.tipo} - PESO: {this.peso}");



            return sr.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Carga )
            {
                retorno = ((Carga)obj) == this;
            }

            return retorno;
        }

        public static bool operator ==(Carga p1, Carga p2)
        {
            bool retorno = false;
            if (p1.codigo == p2.codigo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Carga p1, Carga p2)
        {
            return !(p1 == p2);
        }


         bool ISerializador<Carga>.Escribir(string file, Carga info)
        {
            bool retorno = false;
            try
            {
                using StreamWriter streamWriter = new StreamWriter(file);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Carga));
                xmlSerializer.Serialize(streamWriter, info);
                retorno = true;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
            return retorno;
            
        }

        List<Carga> ISerializador<Carga>.Leer(string archivo, Action<string> mostrarElementos)
        {

            List<Carga> miLista = default;


            try
            {
                if (!string.IsNullOrEmpty(archivo))
                {
                    using StreamReader streamReader = new StreamReader(archivo);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Carga));
                     miLista = (List<Carga>)xmlSerializer.Deserialize(streamReader);

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
