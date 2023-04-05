using System;

namespace _01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

            for (int i =1; i<= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}