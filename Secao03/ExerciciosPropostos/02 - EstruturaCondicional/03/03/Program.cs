using System;

namespace _03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Digite dois valores inteiros: ");
            string[] valores = Console.ReadLine().Split(' ');
            A =int.Parse(valores[0]);
            B =int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("São múltiplos");
            }
            else
            {
                Console.WriteLine("Não são múltiplos");
            }
        }
    }
}
