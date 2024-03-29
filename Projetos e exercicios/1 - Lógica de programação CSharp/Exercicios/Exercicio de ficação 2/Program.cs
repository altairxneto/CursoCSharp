﻿using System;
using System.Globalization;

namespace ExercicioFixacao {
    public class ExercicioF2 {
        public static void Main() {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string informacoes = Console.ReadLine();

            string[] vetorInformacoes = informacoes.Split(' ');

            string ultimoNome = vetorInformacoes[0];
            int idade = int.Parse(vetorInformacoes[1]);
            double altura = double.Parse(vetorInformacoes[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}