using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PP_Laboratorio_II
{
    public class Grupo
    {
        #region Atributos

        private List<Mascota> manada;
        private string nombre;
        private static ETipoManada tipo;
        #endregion

        #region Propiedades

        public ETipoManada Tipo { set { tipo = value; } }
        #endregion

        #region Constructor

        static Grupo()
        {
            Grupo.tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            Grupo.tipo = tipo;
        }
        #endregion

        #region Sobrecargas

        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Grupo:  { g.nombre} - tipo:  {Grupo.tipo}");
            sb.AppendLine($"Integrantes( { g.manada.Count})");

            foreach (Mascota item in g.manada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public static bool operator ==(Grupo g1, Mascota m)
        {
            bool esta = false;
            foreach (Mascota item in g1.manada)
            {
                if (item.Equals(m))
                {
                    esta = true;
                    break;

                }
            }
            return esta;
        }

        public static bool operator !=(Grupo g1, Mascota m)
        {
            return !(g1 == m);
        }

        public static Grupo operator +(Grupo g1, Mascota m)
        {


            if (g1 != m)
            {
                g1.manada.Add(m);

            }

            else
            {
                Console.WriteLine($"Ya esta {m} en el grupo"); //Porque modifique el ToString puedo hacer  Console.WriteLine($"Ya esta {m} en el grupo");
                                                               //Puedo poner el {m}
            }



            return g1;
        }

        public static Grupo operator -(Grupo g1, Mascota m)
        {

            if (g1 == m)
            {

                g1.manada.Remove(m);

            }
            else
            {
                Console.WriteLine($"No esta el {m} en el grupo");//Porque modifique el ToString puedo hacer Console.WriteLine($"No esta el {m} en el grupo");
                                                                 //Puedo poner el {m}
            }

            return g1;
        }
        #endregion

    }
}
       

