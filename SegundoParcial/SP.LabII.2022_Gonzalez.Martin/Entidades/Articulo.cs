using System;

namespace EntidadesSP
{
    public class Articulo
    {
        private string marca;
        private int codigo;
        private double precio;


        public string Marca { get => marca; set => marca = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Precio { get => precio; set => precio = value; }

        public Articulo()
        {

        }
        public Articulo(string marca, int codigo, double precio)
        {
            this.marca = marca;
            this.codigo = codigo;
            this.precio = precio;
        }

        public override string ToString()
        {
            return String.Format($"Codigo: {this.codigo} - Marca: {this.marca} - Precio: {this.precio}");
        }
    }
}
