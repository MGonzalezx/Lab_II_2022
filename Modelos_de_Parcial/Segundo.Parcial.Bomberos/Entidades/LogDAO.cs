using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class LogDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;


        static LogDAO()
        {
            cadenaConexion = @"Server=.;Database=bomberos-db;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;

        }

        public  void Guardar(string info)
        {
            try
            {
                //vamos a trabajar con parámetros, entonces vamos a limpiar el caché

                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = $"INSERT INTO dbo.log (entrada, alumno) VALUES (@entrada, 'Martin Gonzalez')";

                comando.Parameters.AddWithValue("@entrada", info);
               



                comando.ExecuteNonQuery();




            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }


        }

        public  string Leer()
        {
            

            try
            {
                //cada vez que entra en el método, voy a tener que limpiar los parámetros.
                //No pasaria si solo trabajaramos con comandos.
                comando.Parameters.Clear();
                conexion.Open();

                //JUEGOS.NOMBRE as juegos le ponemos de alias juegos a JUEGOS.NOMBRE
                comando.CommandText = $"SELECT entrada FROM dbo.log";

                 StringBuilder stringBuilder = new StringBuilder();

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {

                        stringBuilder.AppendLine(dataReader.GetString(0));
                        
                    }
                }

                return stringBuilder.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            
        }
    }
}
