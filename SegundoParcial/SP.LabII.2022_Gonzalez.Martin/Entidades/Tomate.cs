using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Text.Json;

namespace EntidadesSP
{
    public class Tomate : Articulo, ISerializa, IDeserializa<Tomate>
    {
        public string tipo;

        public Tomate()
        {

        }
        public Tomate(string tipo, string marca, int codigo, double precio ) : base(marca, codigo, precio)
        {
            this.tipo = tipo;
        }

        public string PathXml => GetFolderPath(SpecialFolder.Desktop)+"\\gonzalez.martin.tomate.xml";

        string ISerializa.PathJson => GetFolderPath(SpecialFolder.MyDocuments)+"\\gonzalez.martin.tomate.json";

       

        public bool Xml()
        {
            bool funciona = false;

                try
                {
                    using StreamWriter streamWriter = new StreamWriter(PathXml);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Tomate));
                    xmlSerializer.Serialize(streamWriter, this);
                    funciona = true;
                   
                }
                catch (Exception e)
                {
                    throw ;

                }

            
            return funciona;
        }
        

        bool IDeserializa<Tomate>.Xml(out Tomate datos)
        {
             bool funciona = false;
            try
            {
                using StreamReader streamReader = new StreamReader(PathXml);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Tomate));
                datos = (Tomate)xmlSerializer.Deserialize(streamReader);

                funciona = true;
            }
            catch (Exception)
            {

                throw;
            }
            return funciona;
        }

        bool ISerializa.Json()
        { bool funciona = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(GetFolderPath(SpecialFolder.MyDocuments)+"\\gonzalez.martin.tomate.json"))
                {
                    string json = JsonSerializer.Serialize(typeof(Tomate));
                    writer.WriteLine(json);

                     funciona = true;
                }
            }
            catch (Exception ex)
            {

                throw ;
            }
            return funciona;
        }

        public bool Json(out Tomate datos)
        {
            bool funciona = false;
            try
            {
                using (StreamReader sr = new StreamReader(GetFolderPath(SpecialFolder.MyDocuments)+"\\gonzalez.martin.tomate.json"))
                {
                    string json_str = sr.ReadToEnd();

                    Console.WriteLine(json_str);

                    datos = (Tomate)JsonSerializer.Deserialize(json_str, typeof(Tomate));
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return funciona;
        }
        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.Append(base.ToString());

            sr.Append($" - Tipo: {this.tipo}");

            return sr.ToString();
        }
    }

    
}
