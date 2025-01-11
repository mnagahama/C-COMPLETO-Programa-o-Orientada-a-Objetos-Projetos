using _03;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
            {
                Console.WriteLine("Aprovado");
            }

            else 
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
            }

        }
    }
}