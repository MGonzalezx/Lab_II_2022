using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Entidades.Final
{
    public class Login
    {
        protected string email;
        protected string pass;
        public string Email { get => email; }
        public string Pass { get => pass;  }

        public Login(string correo, string clave)
        {
            this.email = correo;
            this.pass = clave;
        }

        public bool Loguear()
        {


             string conexion;
             SqlCommand comando;
             SqlConnection conexionSql;

            conexion = @"Server=.;Database=laboratorio_2;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexionSql = new SqlConnection(conexion);
            comando.Connection = conexionSql;
            comando.CommandType = System.Data.CommandType.Text;

            bool retorno = false;

            try
            {

                comando.Parameters.Clear();
                conexionSql.Open();


                comando.CommandText = "SELECT * FROM usuarios WHERE correo = @correo AND clave = @clave";
                comando.Parameters.AddWithValue("@correo", this.Email);
                comando.Parameters.AddWithValue("@clave", this.Pass);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    string _correo = reader.GetString(3);
                    string _clave = reader.GetString(4);


                    if (_correo == this.Email && _clave == this.Pass)
                    {
                        retorno = true;
                    }

                }
                return retorno;


            }
            catch (Exception ex)
            {
                throw new ExcepcionesADO(ex);

            }
            finally
            {
                conexionSql.Close();
            }

           
            }
        }
    }

