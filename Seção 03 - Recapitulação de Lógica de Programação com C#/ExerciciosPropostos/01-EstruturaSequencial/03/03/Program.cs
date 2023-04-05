using System;

namespace _03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;
            Console.WriteLine("Digite um valor para A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para D: ");
            D = int.Parse(Console.ReadLine());

            diferenca = (A*B) - (C*D);
            Console.WriteLine("A diferença entre (A+B) e (C-D) é: " + diferenca);
        }
    }
}