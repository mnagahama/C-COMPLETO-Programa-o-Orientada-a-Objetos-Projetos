using _02;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Funcionario funcionario = new Funcionario();

            Console.WriteLine("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salario: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Dados do funcionario: " + funcionario);

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem ? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + funcionario);

        }
    }
}