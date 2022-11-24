using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Text.Json;
using System.IO;

namespace Entidades.RSP
{
    public class Pintura : ISerializador<Pintura>
    {
        public string color;
        public string marca;
        public Int32 codigo;

        public string Color { get => color; set => color = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        public Pintura()
        {

        }
        public Pintura(string color, string marca, Int32 codigo) : this()
        {
            this.color = color;
            this.marca = marca;
            this.codigo = codigo;
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"COLOR: {this.color} - MARCA: {this.marca} - CÓDIGO: {this.codigo}");



            return sr.ToString();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (!(obj == null) && obj is Pintura)
            {
                retorno = ((Pintura)obj) == this;
            }

            return retorno;
        }

        public static bool operator ==(Pintura p1, Pintura p2)
        {
            bool retorno = false;
            if (p1.codigo == p2.codigo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Pintura p1, Pintura p2)
        {
            return !(p1 == p2);
        }

        public bool Escribir(string file, Pintura info)
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



        public List<Pintura> Leer(string archivo, Action<string> mostrarElementos)
        {

            List<Pintura> miLista;


            try
            {
                if (!string.IsNullOrEmpty(archivo))
                {
                    miLista = JsonSerializer.Deserialize<List<Pintura>>(File.ReadAllText(archivo));
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
