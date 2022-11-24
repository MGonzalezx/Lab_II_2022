using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public static class JsonManager <T>
    {
        private static string file;
        static JsonManager()
        {
            file = "votacion.json";
        }
        public static void Guardar(string file, T contenido)
        {
            JsonManager<T>.file = file;
            Guardar( contenido);
        }
        public static void Guardar(T contenido)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    string json = JsonSerializer.Serialize(contenido);
                    writer.WriteLine(json);
                }
            }
            catch (Exception ex)
            {

                throw new FileException("Error al guardar el archivo",ex);
            }
            
        }
    }
}
