using System;

namespace _02 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o intervalo: ");
            int n = int.Parse(Console.ReadLine());

            int intervalo_in = 0;
            int intervalo_out = 0;

            for (int i=0; i <=n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    intervalo_in++;
                }

                else
                {
                    intervalo_out++;
                }
                
            }

            Console.WriteLine(intervalo_in + " in");
            Console.WriteLine(intervalo_out + " out");
        }
    }
}