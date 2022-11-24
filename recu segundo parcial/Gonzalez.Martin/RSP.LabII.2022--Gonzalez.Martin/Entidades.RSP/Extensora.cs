using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades.RSP
{
    public static class Extensora
    {
        private static string conexion;
        static SqlCommand comando;
        static SqlConnection cadenaConexion;
       

        static Extensora()
        {
            conexion = (@"Data Source=.;Database=pasajeros_db;Trusted_Connection=True;");
            comando = new SqlCommand();
            cadenaConexion = new SqlConnection(conexion);
            comando.Connection = cadenaConexion;
            comando.CommandType = System.Data.CommandType.Text;


        }

        public static List<Pasajero> ObtenerTodosBD(this Pasajero miPasajero)
        {
            List<Pasajero> pasajeros = new List<Pasajero>();
            
            try
            {

                comando.Parameters.Clear();
                cadenaConexion.Open();


                comando.CommandText = $"SELECT dni as Dni, nombre as Nombre, equipaje as Equipaje FROM pasajeros";
                   



                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {



                        pasajeros.Add(miPasajero = new Pasajero(Convert.ToInt32(dataReader["Dni"]), dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["Equipaje"])));
                           



                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cadenaConexion.Close();
            }

            return pasajeros;
        }


         public static Boolean AgregarBD(this Pasajero miPasajero)
        {
            try
            {
                List<string> auxLista = new List<string>();

              

                comando.CommandText = "INSERT INTO pasajeros VALUES (@Dni,@Nombre,@Equipaje)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Dni", miPasajero.dni);
                comando.Parameters.AddWithValue("@Nombre", miPasajero.nombre);
                comando.Parameters.AddWithValue("@Equipaje", miPasajero.equipaje);
                

                if (cadenaConexion.State != ConnectionState.Open)
                {
                    cadenaConexion.Open();
                }

                return comando.ExecuteNonQuery() != 0;
            }
            
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                cadenaConexion.Close();
            }
        }

        public static Boolean ModificarBD(this Pasajero miPasajero)
        {
            try
            {


                comando.Parameters.Clear();
                cadenaConexion.Open();

                comando.CommandText = $"UPDATE pasajeros SET dni = @Dni, nombre = @Nombre, equipaje = @Equipaje WHERE dni = @Dni";

                comando.Parameters.AddWithValue("@Dni", miPasajero.dni);
                comando.Parameters.AddWithValue("@Nombre", miPasajero.nombre);
                comando.Parameters.AddWithValue("@Equipaje", miPasajero.equipaje);
                



               return comando.ExecuteNonQuery() != 0;




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cadenaConexion.Close();
            }
        }

        public static Boolean EliminarBD(this Pasajero miPasajero)
        {
            try
            {
                comando.Parameters.Clear();
                cadenaConexion.Open();
                comando.CommandText = $"DELETE FROM pasajeros WHERE dni = @Dni";
                comando.Parameters.AddWithValue("@Dni", miPasajero.dni);


                return comando.ExecuteNonQuery() != 0;




            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cadenaConexion.Close();
            }
        }
    }
    
}
