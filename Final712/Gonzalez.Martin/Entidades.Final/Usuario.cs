using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Final
{
    public class Usuario
    {
        private string apellido;
        private string clave;
        private string correo;
        private int dni;
        private string nombre;

        public string Apellido { get => apellido; set => apellido = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }


        public Usuario() 
        {

        }

        public Usuario(string nombre,string apellido , int dni , string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.correo = correo;
        }

        public Usuario(string nombre, string apellido, int dni, string correo, string clave) : this(nombre, apellido, dni, correo)
        {
            this.clave = clave;
           
        }

        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();

            sr.AppendLine($"NOMBRE: {this.nombre} - APELLIDO: {this.apellido} - DNI: {this.dni} - CORREO: {this.correo}");



            return sr.ToString();
        }
    }
}
