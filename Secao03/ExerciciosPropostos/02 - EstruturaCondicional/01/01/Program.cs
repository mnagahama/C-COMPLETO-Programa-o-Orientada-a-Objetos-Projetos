using System;

namespace _01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Digite um numero inteiro: ");
            a = int.Parse(Console.ReadLine());

            if (a < 0) {
                Console.WriteLine("Negativo");
            }

            else
            {
                Console.WriteLine("Não negativo");
            }
        }
    }
}