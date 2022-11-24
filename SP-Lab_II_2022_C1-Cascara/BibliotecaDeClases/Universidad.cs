using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public class Universidad
    {
        List<Carrera> listaCarreras;//no modificar
        int capacidad;//no modificar

        public List<Carrera> ListaCarreras { get => listaCarreras; }//no modificar
        public event Action<bool> cupoLleno;

        public Universidad(int cupo) //no modificar metodo
        {
            this.capacidad = cupo;
            listaCarreras = new List<Carrera>();
        }
      

        // completar metodo
        public List<Carrera> AgregarNuevaCarrera()
        {

            if (listaCarreras.Count <= capacidad)
            {
                listaCarreras.Add(GeneradorDeDatos.GetUnaCarrera);
            }
            else
            {
                cupoLleno.Invoke(true);
            }

            return ListaCarreras;
        }

    }
}
