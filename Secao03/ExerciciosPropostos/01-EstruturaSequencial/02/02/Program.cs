using System;
using System.Globalization;

namespace _02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area,pi = 3.14159;
            Console.WriteLine("Digite o raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = raio* raio * pi;

            Console.WriteLine("Area do circlo: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}