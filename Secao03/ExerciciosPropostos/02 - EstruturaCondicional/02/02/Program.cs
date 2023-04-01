using System;

namespace _02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Digite um numero inteiro: ");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Par");
            }

            else
            {
                Console.WriteLine("Ímpar");
            }
        }
    }
}