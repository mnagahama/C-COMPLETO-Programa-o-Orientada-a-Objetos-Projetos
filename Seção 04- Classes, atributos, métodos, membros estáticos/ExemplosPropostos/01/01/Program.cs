using System;
using System.Globalization;

namespace _01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retangulo: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Area: " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}