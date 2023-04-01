using System;
using System.Globalization;

namespace _05 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Cachorro Quente - R$4,00");
            Console.WriteLine("2 - X-Salada - R$4,00");
            Console.WriteLine("3 - X-Bacon - R$5,00");
            Console.WriteLine("4 - Torrada Simples - R$4,50");
            Console.WriteLine("5 - Refrigerante - R$1,50");
            Console.WriteLine("Digite o item e a quantidade desejada: ");
            string[] valores = Console.ReadLine().Split(' ');
            int item = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            double total;

            if (item == 1)
            {
                total =  quantidade * 4.0;
                Console.WriteLine($"Item {item} escolhido");
                Console.WriteLine($"{quantidade} Cachorro(s) Quente(s)" );
                Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            if (item == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine($"Item {item} escolhido");
                Console.WriteLine($"{quantidade} X-Salada(s)");
                Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            if (item == 3)
            {
                total = quantidade * 5.0;
                Console.WriteLine($"Item {item} escolhido");
                Console.WriteLine($"{quantidade} X-Bacon(s)");
                Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            if (item == 4)
            {
                total = quantidade * 2.0;
                Console.WriteLine($"Item {item} escolhido");
                Console.WriteLine($"{quantidade} Torrada(s) Simples");
                Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
            if (item == 5)
            {
                total = quantidade * 1.50;
                Console.WriteLine($"Item {item} escolhido");
                Console.WriteLine($"{quantidade} Refrigerante(s)");
                Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
            }
        }
    }
}