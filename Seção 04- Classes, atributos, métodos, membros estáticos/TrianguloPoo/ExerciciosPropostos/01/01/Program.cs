using System;

namespace _01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Entre com os dados da primeira pessoa.");
            Console.WriteLine("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados da segunda pessoa.");
            Console.WriteLine("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + pessoa2.Nome);
            }
        }
    }
}