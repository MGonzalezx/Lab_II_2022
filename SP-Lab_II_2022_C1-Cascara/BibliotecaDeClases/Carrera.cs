namespace BibliotecaDeClases
{
    public class Carrera : ICalificacion
    {
        string nombre; // no modificar linea

        // no modificar metodo
        public Carrera(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; } // no modificar linea


        //completar

        public decimal CalificacionFinal
        {
            get
            {
                return GeneradorDeDatos.Rnd.Next(1,11);
            }
        }


        public override string ToString()
        {
            return this.nombre  + " - " + "Puntaje del curso: " + this.CalificacionFinal.ToString();
        }



    }
}
