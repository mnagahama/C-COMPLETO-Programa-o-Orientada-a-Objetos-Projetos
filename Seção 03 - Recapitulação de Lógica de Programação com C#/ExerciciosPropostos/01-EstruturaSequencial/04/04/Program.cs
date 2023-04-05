using System;
using System.Globalization;

namespace _04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, time;
            double price, salary;

            Console.WriteLine("Digite o numero do funcionario: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero de horas trabalhadas: ");
            time = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor que recebe por hora: ");
            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = time * price;
            Console.WriteLine($"O numero do funcionario é: {number} e o seu salário é U${salary:F2}", CultureInfo.InvariantCulture);
        }
    }
}
