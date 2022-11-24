using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Text.Json;
using static System.Environment;

namespace Entidades
{
    public sealed class Combate
    {
        public delegate void DelegadoCombate(IJugador j1, IJugador j2);

        public event DelegadoCombate RondaIniciada;
        public event Action<IJugador> CombateFinalizado;

        private IJugador atacado;
        private IJugador atacante;
        static Random random;

        static Combate()
        {
            random = new Random();
        }

        public Combate(IJugador jugadorUno, IJugador jugadorDos)
        {
            atacante = SeleccionarJugadorAleatoriamente(jugadorUno, jugadorDos);
            atacado = atacante.Equals(jugadorUno) ? jugadorDos : jugadorUno;
        }

        private void Combatir()
        {

            IJugador ganador;
            do
            {
                IniciarRonda();
                ganador = EvaluarGanador();
            } while (ganador is null);

            if (CombateFinalizado is not null)
            {
                CombateFinalizado.Invoke(ganador);
            }

            GuardarResultado(new ResultadoCombate(ganador.ToString(), atacado.ToString(), DateTime.Now));



        }

        private void GuardarResultado(ResultadoCombate resultado)
        {
            string json = JsonSerializer.Serialize(resultado);
            new Logger(GetFolderPath(SpecialFolder.Desktop) + "\\resultados.json").GuardarLog(json);
        }

        private IJugador EvaluarGanador()
        {
            if (atacado.PuntosDeVida == 0)
            {
                return atacante;
            }
            else
            {
                IJugador aux = atacante;
                atacante = atacado;
                atacado = aux;
                return null;
            }

            
        }

        public Task IniciarCombate()
        {
            return Task.Run(Combatir);
        }

        private void IniciarRonda()
        {
            if (RondaIniciada is not null)
            {
                RondaIniciada.Invoke(atacante, atacado);
            }
            int puntos = atacante.Atacar();
            atacado.RecibirAtaque(puntos);
        }

        private static IJugador SeleccionarJugadorAleatoriamente(IJugador jugadorUno, IJugador jugadorDos)
        {
            if (random.TirarUnaMoneda() == LadosMonedas.Cara)
            {
                return jugadorUno;
            }
            else
            {
                return jugadorDos;
            }
        }

        private static IJugador SeleccionarPrimerAtacante(IJugador jugadorUno, IJugador jugadorDos)
        {
            if (jugadorUno.Nivel < jugadorDos.Nivel)
            {
                return jugadorUno;
            }
            else if (jugadorUno.Nivel > jugadorDos.Nivel)
            {
                 return jugadorDos;
                
            }else
            {
               return SeleccionarJugadorAleatoriamente(jugadorUno, jugadorDos);
            }
        }
    }
}
