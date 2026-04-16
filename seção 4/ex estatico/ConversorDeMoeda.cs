using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClasseEstaticaEx
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double Total = quantia * cotacao;
            return Total+ Total * Iof / 100.0;
        }
    }
}
