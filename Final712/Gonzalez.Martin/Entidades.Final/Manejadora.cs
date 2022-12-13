using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace Entidades.Final
{
    public class Manejadora
    {
        public static bool EscribirArchivo(List<Usuario> users)
        {
            bool retorno = false;
            const string nombreArchivo = "usuarios.log";
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = Path.Combine(rutaEscritorio, nombreArchivo);
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(DateTime.Now);
                    writer.WriteLine($"Apellido: {users.First().Apellido}");
                    writer.WriteLine("Correos:");

                    foreach (Usuario miUsuario in users)
                    {

                        writer.WriteLine(miUsuario.Correo);

                    }
                    writer.WriteLine("......................");
                }
                retorno = true;
            }
            catch (Exception e )
            {

               throw new ArchivosException(e);
            }

            return retorno;
           
        }

        public static bool SerializarJSON(List<Usuario> users, string path)
        {
            bool retorno = false;


            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {

                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    string json = JsonSerializer.Serialize(users,opciones);
                  

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

        public static bool DeserializarJSON(string path, out List<Usuario> users)
        {
            bool retorno = false;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    users = JsonSerializer.Deserialize<List<Usuario>>(File.ReadAllText(path));
                    //miLista = JsonSerializer.Deserialize<Pintura>(File.ReadAllText(archivo));
                    retorno = true;
                }
                else
                {
                    throw new DirectoryNotFoundException("no encontrado");
                    
                }

                return retorno;
            }

            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
    }
}
