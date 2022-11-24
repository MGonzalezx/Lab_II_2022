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
    public class Pintura : Articulo, ISerializa, IDeserializa<Pintura>
    {
        protected string color;


        public string Color { get => color; set => color = value; }

        public Pintura()
        {

        }
        public Pintura(string color, string marca, int codigo, double precio) : base(marca, codigo, precio)
        {
            this.color = color;
        }
        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.Append(base.ToString());

            sr.Append($" - Color: {this.color}");

            return sr.ToString();
        }


       

        public string PathJson =>  GetFolderPath(SpecialFolder.MyDocuments)+"\\gonzalez.martin.pintura.json";

        string ISerializa.PathXml => GetFolderPath(SpecialFolder.Desktop)+"\\gonzalez.martin.pintura.xml";

        public bool Json()
        {
            bool funciona = false;
            try
            {
                using (StreamWriter writer = new StreamWriter(PathJson))
                {
                    string json = JsonSerializer.Serialize(typeof(Pintura));
                    writer.WriteLine(json);

                    funciona = true;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return funciona;
        }

        bool ISerializa.Xml()
        {
            bool funciona = false;

            try
            {
                using StreamWriter streamWriter = new StreamWriter(GetFolderPath(SpecialFolder.Desktop) + "\\gonzalez.martin.pintura.xml"));
);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Pintura));
                xmlSerializer.Serialize(streamWriter, this);
                funciona = true;

            }
            catch (Exception e)
            {
                throw;

            }


            return funciona;
        }

        public bool Xml(out Pintura datos)
        {
            bool funciona = false;
            try
            {
                using StreamReader streamReader = new StreamReader(GetFolderPath(SpecialFolder.Desktop) + "\\gonzalez.martin.pintura.xml");
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

        bool IDeserializa<Pintura>.Json(out Pintura datos)
        {
            throw new NotImplementedException();
        }
    }
}
