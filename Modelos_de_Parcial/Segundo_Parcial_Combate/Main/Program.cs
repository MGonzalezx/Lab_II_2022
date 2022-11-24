﻿using System;
using Entidades;
using static System.Environment;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Personaje personaje1 = PersonajeDAO.ObtenerPersonajePorId(1);
            personaje1.AtaqueLanazado += MostrarAtaqueLanzado;
            personaje1.AtaqueRecibido += MostrarAtaqueRecibido;

            Personaje personaje2 = PersonajeDAO.ObtenerPersonajePorId(2);
            personaje2.AtaqueLanazado += MostrarAtaqueLanzado;
            personaje2.AtaqueRecibido += MostrarAtaqueRecibido;


            Combate combate = new Combate(personaje1, personaje2);
            combate.RondaIniciada += IniciarRonda;
            combate.CombateFinalizado += FinalizarCombate;

            Console.WriteLine("¡FIGHT!");

            try
            {
                 combate.IniciarCombate().Wait();
            }
            catch (BusinessException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                string txt = $"ERROR: {e.Message} - {e.StackTrace}";
                new Logger(GetFolderPath(SpecialFolder.Desktop)+"\\log.txt").GuardarLog(txt);
            }

           
        }

        static void IniciarRonda(IJugador atacante, IJugador atacado)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"¡{atacante} ataca a {atacado}!");
        }

        static void FinalizarCombate(IJugador ganador)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Combate finalizado. El ganador es {ganador}.");
        }

        static void MostrarAtaqueLanzado(Personaje personaje, int puntosDeAtaque)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{personaje} lanzó un ataque de {puntosDeAtaque} puntos.");
        }

        static void MostrarAtaqueRecibido(Personaje personaje, int puntosDeAtaque)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{personaje} recibió un ataque por {puntosDeAtaque} puntos. Le quedan {personaje.PuntosDeVida} puntos de vida.");
        }
    }
}
