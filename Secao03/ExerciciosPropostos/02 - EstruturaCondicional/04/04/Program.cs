﻿
using System;

namespace _04 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a hora inicial e a hora final: ");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }

            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O jogo durou: " + duracao + " hora(s)");
        }
    }
}