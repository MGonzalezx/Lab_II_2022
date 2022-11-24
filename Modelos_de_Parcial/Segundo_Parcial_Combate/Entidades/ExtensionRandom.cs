using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum LadosMonedas
    {
        Cara = 1, 
        Ceca 
    }
    public static class ExtensionRandom
    {
        public static LadosMonedas TirarUnaMoneda(this Random random)
        {
            //El maximo es excluido
            return (LadosMonedas)random.Next(1, 3);
        }
    }
}
