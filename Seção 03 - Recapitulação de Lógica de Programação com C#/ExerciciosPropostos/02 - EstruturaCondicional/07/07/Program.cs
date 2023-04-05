using System;
using System.Globalization;

namespace _07 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os valores para x e y: ");
            string[] valores = Console.ReadLine().Split();
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1],CultureInfo.InvariantCulture);

            if (x==0 && y==0)
            {
                Console.WriteLine("Eixo x: " + x.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Eixo y: " + y.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Origem");
            }

            if (x > 0 && y >0)
            {
                Console.WriteLine("Eixo x: " + x.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Eixo y: " + y.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Q1");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("Eixo x: " + x.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Eixo y: " + y.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Q2");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("Eixo x: " + x.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Eixo y: " + y.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Q3");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Eixo x: " + x.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Eixo y: " + y.ToString("F2"), CultureInfo.InvariantCulture);
                Console.WriteLine("Q4");
            }
        }
    }
}
