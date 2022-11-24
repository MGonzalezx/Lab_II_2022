using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public abstract class Personaje : IJugador
    {
        private decimal id;
        private short nivel;
        private string nombre;
        protected int puntosDeDefensa;
        protected int puntosDePoder;
        protected int puntosDeVida;
        static Random random;
        private string titulo;
        const int nivelMaximo = 100;
        const int nivelMinimo = 1;


        public event Action<Personaje, int> AtaqueLanazado;
        public event Action<Personaje, int> AtaqueRecibido;


        public string Titulo { set => titulo = value; }

        public short Nivel { get => nivel; }

        public int PuntosDeVida { get => puntosDeVida; }

        public int PuntosDeDefensa { get => puntosDeDefensa; }

        static Personaje()
        {
            random = new Random();
        }
        public Personaje(decimal id, string nombre , short nivel )
        {

            puntosDeDefensa = 100 * nivel;
            puntosDeVida = 500 * nivel;
            puntosDePoder = 100 * nivel;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentNullException();
            }
           
            //trim borrar los espacios al inicio y al final
            this.nombre = nombre.Trim();
            this.id = id;
            if (nivel >= nivelMinimo && nivel <= nivelMaximo)
            {
                this.nivel = nivel;
            }
            else
            {
                throw new BusinessException("El nivel tiene que estar entre 1 y 100!!");
            }
            
           
        }

        public Personaje(decimal id, string nombre) : this(id, nombre, 1)
        {
           
        }

        public abstract void AplicarBeneficiosDeClase();
        

        public override bool Equals(object obj)
        {
            return this == obj as Personaje;
        }

        public override int GetHashCode()
        {
            return this.id.GetHashCode();
        }

        public override string ToString()
        {
            //string.IsNullOrEmpty(titulo) ? "" :$" ,{ titulo"} si es nulo o está empty no ponemos nada, sino ponemos el titulo 
            return String.Format("{0}{1}", nombre, string.IsNullOrEmpty(titulo) ? "" :$" ,{titulo}");
        }

        public int Atacar()
        {
            Thread.Sleep(random.Next(1000, 5001));
            int puntosDeAtaque = puntosDePoder * random.Next(10, 101) / 100;

            if (AtaqueLanazado is not null)
            {
                AtaqueLanazado.Invoke(this, puntosDeAtaque);
            }

            return puntosDeAtaque;
        }

        public void RecibirAtaque(int puntosDeAtaque)
        {
            puntosDeAtaque -=  puntosDeDefensa * random.Next(10, 101) / 100;
            puntosDeVida -= puntosDeAtaque;
            if (puntosDeVida < 0)
            {
                puntosDeVida = 0;
            }
            if (AtaqueRecibido is not null)
            {
                AtaqueRecibido.Invoke(this, puntosDeAtaque);
            }
        }

        public static bool operator ==(Personaje p1, Personaje p2)
        {
            return p1 is not null && p2 is not null && p1.GetHashCode() == p2.GetHashCode();
        }

        public static bool operator !=(Personaje p1, Personaje p2)
        {
            return !(p1 == p2);
        }



    }
}
