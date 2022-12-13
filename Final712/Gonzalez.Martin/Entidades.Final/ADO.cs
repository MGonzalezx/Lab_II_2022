using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades.Final
{
    public delegate void ApellidoUsuarioExistenteDelegado(object sender, EventArgs args);
    public class ADO
    {
        private static string conexion;
        static SqlCommand comando;
        static SqlConnection conexionSql;
        public event ApellidoUsuarioExistenteDelegado ApellidoUsuarioExistente;
        static ADO()
        {
            conexion = @"Server=.;Database=laboratorio_2;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexionSql = new SqlConnection(conexion);
            comando.Connection = conexionSql;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public bool Agregar(Usuario user)
        {
            bool retorno = false;
            try
            {
                List<Usuario> miLista;
                miLista = ObtenerTodos(user.Apellido);

                if(miLista.Count >= 1)
                {
                   
                    comando.Parameters.Clear();
                    conexionSql.Open();
                    comando.CommandText = $"INSERT INTO usuarios (nombre, apellido, dni, correo,clave) VALUES (@nombre, @apellido, @dni, @correo,@clave)";
                    comando.Parameters.AddWithValue("@nombre", user.Nombre);
                    comando.Parameters.AddWithValue("@apellido", user.Apellido);
                    comando.Parameters.AddWithValue("@dni", user.Dni);
                    comando.Parameters.AddWithValue("@correo", user.Correo);
                    comando.Parameters.AddWithValue("@clave", user.Clave);

                    comando.ExecuteNonQuery();
                     this.ApellidoUsuarioExistente(this, new EventArgs());
                    retorno = true;
                }
                else
                {
                    comando.Parameters.Clear();
                    conexionSql.Open();
                    comando.CommandText = $"INSERT INTO usuarios (nombre, apellido, dni, correo,clave) VALUES (@nombre, @apellido, @dni, @correo,@clave)";
                    comando.Parameters.AddWithValue("@nombre", user.Nombre);
                    comando.Parameters.AddWithValue("@apellido", user.Apellido);
                    comando.Parameters.AddWithValue("@dni", user.Dni);
                    comando.Parameters.AddWithValue("@correo", user.Correo);
                    comando.Parameters.AddWithValue("@clave", user.Clave);

                    comando.ExecuteNonQuery();

                    retorno = true;
                }
               

                
            }
            catch (Exception e)
            {
                throw new ExcepcionesADO(e);
            }
            finally
            {
                conexionSql.Close();
            }

            return retorno;
        }

        public bool Eliminar(Usuario user)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexionSql.Open();
                comando.CommandText = $"DELETE FROM usuarios WHERE dni = @dni";
                comando.Parameters.AddWithValue("@dni", user.Dni);
                comando.ExecuteNonQuery();


                retorno = true;

            }
            catch (Exception ex)
            {
                throw new ExcepcionesADO(ex);

            }
            finally
            {
                conexionSql.Close();
            }
            return retorno;
        }

        public bool Modificar(Usuario user)
        {
            bool retorno = false;
            try
            {
                comando.Parameters.Clear();
                conexionSql.Open();
                comando.CommandText = $"UPDATE usuarios SET nombre = @Nombre, apellido = @Apellido, dni = @Dni, correo = @Correo, clave = @Clave WHERE dni = {user.Dni}";
                comando.Parameters.AddWithValue("@Nombre", user.Nombre);
                comando.Parameters.AddWithValue("@Apellido", user.Apellido);
                comando.Parameters.AddWithValue("@Dni", user.Dni);
                comando.Parameters.AddWithValue("@Correo", user.Correo);
                comando.Parameters.AddWithValue("@Clave", user.Clave);
        
                comando.ExecuteNonQuery();


                retorno = true;

            }
            catch (Exception ex)
            {
                throw new ExcepcionesADO(ex);

            }
            finally
            {
                conexionSql.Close();
            }
            return retorno;
        }

        public static List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                
                comando.Parameters.Clear();
                conexionSql.Open();


                comando.CommandText = $"SELECT nombre as Nombre, apellido as apellido, dni as Dni, " +
                    $"correo as Correo, clave as Clave FROM usuarios";



                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {



                        usuarios.Add(new Usuario(dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), Convert.ToInt32(dataReader["Dni"]), dataReader["Correo"].ToString(),
                            dataReader["Clave"].ToString()));



                    }
                }


            }
            catch (Exception ex)
            {
                throw new ExcepcionesADO(ex);

            }
            finally
            {
                conexionSql.Close();
            }

            return usuarios;
        }

        public static List<Usuario> ObtenerTodos(string apellidoUsuario)
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                
                comando.Parameters.Clear();
                conexionSql.Open();


                comando.CommandText = $"SELECT nombre as Nombre, apellido as Apellido, dni as Dni, " +
                    $"correo as Correo, clave as Clave FROM usuarios WHERE apellido = @miApellido ";
                 comando.Parameters.AddWithValue("@miApellido", apellidoUsuario);


                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {



                        usuarios.Add(new Usuario(dataReader["Nombre"].ToString(), dataReader["Apellido"].ToString(), Convert.ToInt32(dataReader["Dni"]), dataReader["Correo"].ToString(),
                            dataReader["Clave"].ToString()));



                    }
                }


            }
            catch (Exception ex)
            {
                throw new ExcepcionesADO(ex);

            }
            finally
            {
                conexionSql.Close();
            }

            return usuarios;
        }

    }
}

