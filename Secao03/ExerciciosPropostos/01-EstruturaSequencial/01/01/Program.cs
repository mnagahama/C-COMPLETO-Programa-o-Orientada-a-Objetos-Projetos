using System;

namespace _01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int x, y, soma;
        Console.WriteLine("Digite um valor para x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um valor para y: ");
        y = int.Parse(Console.ReadLine());

        soma = x + y;
        Console.WriteLine("A soma de x + y é: " + soma);
    }
    }
}
