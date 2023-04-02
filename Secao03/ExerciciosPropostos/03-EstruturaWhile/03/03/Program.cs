using System;

namespace _03 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            Console.WriteLine("Escolha uma das opções acima: ");

            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            while (codigo != 4) {
                if (codigo == 1) {
                    alcool = alcool + 1;
                    Console.WriteLine("Escolha uma das opções acima: ");
                }
                else if (codigo == 2) {
                    Console.WriteLine("Escolha uma das opções acima: ");
                    gasolina = gasolina + 1;
                }
                else if (codigo == 3) {
                    Console.WriteLine("Escolha uma das opções acima: ");
                    diesel = diesel + 1;
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
            Console.ReadLine();
        }
    }
}