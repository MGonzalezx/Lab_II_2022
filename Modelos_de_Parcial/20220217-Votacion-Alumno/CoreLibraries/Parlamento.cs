using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoreLibraries
{
    public enum EVoto { Indefinido, Abstencion, Positivo, Negativo }

    //delegado fuera de la clase
    public delegate void FinalizarRegistro();
    public class Parlamento<T>
        where T : IParlamentario
    {
        //delegado dentro de la clase
        public delegate void InformarCambioEstado(T obj);

        //eventos
        public event FinalizarRegistro FinVotacion;
        public event FinalizarRegistro ParlamentariosRegistrados;
        public event InformarCambioEstado OcupaBanca;
        public event InformarCambioEstado VotoEmitido;

        public Action<Exception> ExceptionOcurrida;

        private List<T> bancas;
        private bool estadoSesion;
        private T presidente;

        public List<T> Bancas { get => bancas; set => bancas = value; }
        public bool EstadoSesion
        {
            set
            {
                estadoSesion = value;
                Task.Run(() =>
                {
                    foreach (T t in Bancas)
                    {
                        t.AperturaSesion = estadoSesion;
                        if (OcupaBanca is not null)
                        {
                            OcupaBanca.Invoke(t);
                        }
                        Thread.Sleep(50);
                    }
                    ParlamentariosRegistrados?.Invoke();
                });
            }
        }
        public T Presidente { get => presidente; set => presidente = value; }

        public int VotosAbstenciones { get => ContarVotos(EVoto.Abstencion); }
        public int VotosNegativos { get => ContarVotos(EVoto.Negativo); }
        public int VotosAfirmativos { get => ContarVotos(EVoto.Positivo); }

        public void CancelarVotacion()
        {

        }
        private int ContarVotos(EVoto voto)
        {
            int cantidadVotos = 0;
            foreach (T item in bancas)
            {
                if (item.Voto == voto)
                {
                    cantidadVotos++;
                }
            }
            return cantidadVotos;
        }
        public void DesempatePresidente()
        {
            if (VotosAfirmativos == VotosNegativos)
            {
                presidente.EmitirVoto();

                VotoEmitido.Invoke(presidente);
            }
            else
            {
                throw new NoNecesitaDesempateException();
            }
        }
        public void IniciarVotacion()
        {
            Task.Run(() =>
            {
                foreach (T item in bancas)
                {
                    if (item.Presentismo)
                    {
                        item.EmitirVoto();
                        VotoEmitido?.Invoke(item);
                        Thread.Sleep(new Random().Next(400, 1001));
                    }
                }
                try
                {

                    DesempatePresidente();
                }
                catch (Exception ex)
                {
                    ExceptionOcurrida.Invoke(ex);
                    
                }
                FinVotacion.Invoke();
                JsonManager< Parlamento<T> >.Guardar(this);
            });
        }
        public Parlamento(T presidente)
        {
            this.presidente = presidente;
            this.bancas = new List<T>();
        }

    }
}
