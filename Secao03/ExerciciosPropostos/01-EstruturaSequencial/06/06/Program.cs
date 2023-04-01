using System;
using System.Globalization;

namespace _06 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Entre com os valores de A, B, C: ");
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2;
            circulo = 3.14159 * C * C;
            trapezio = (A + B) / 2.0 * C;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("Triangulo: " + triangulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Circulo: " + circulo.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Trapezio: " + trapezio.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Quadrado: " + quadrado.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Retangulo: " + retangulo.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}