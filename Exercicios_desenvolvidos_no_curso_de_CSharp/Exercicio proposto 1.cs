﻿using System;

namespace ExercicioProposto1 {
    public class ExercicioP1 {
        public void ExP1(){
            Console.WriteLine("Digite os dois valores inteiros para efetuar a soma!");
            
            Console.WriteLine("Valor 1: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor 2: ");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = valor1 + valor2;

            Console.WriteLine("Soma = "+resultado);
        }
    }
}
