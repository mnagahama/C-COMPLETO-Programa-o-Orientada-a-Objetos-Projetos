using System;

namespace MembrosEstaticos
{
    internal class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * r * Pi;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
