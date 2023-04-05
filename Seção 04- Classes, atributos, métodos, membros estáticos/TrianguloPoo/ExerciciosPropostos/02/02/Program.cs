using System;
using System.Globalization;

namespace _02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            double salarioMedio;

            Console.WriteLine("Digite os dados do funcionario 1: ");
            Console.WriteLine("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os dados do funcionario 2: ");
            Console.WriteLine("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.WriteLine("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioMedio = (funcionario1.Salario + funcionario2.Salario)/2;

            Console.WriteLine("Salario médio dos dois funcionarios é: " + salarioMedio.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}