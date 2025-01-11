using System;

namespace _04
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 6.0f;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
