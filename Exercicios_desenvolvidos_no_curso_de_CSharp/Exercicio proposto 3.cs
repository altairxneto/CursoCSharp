using System;

namespace ExercicioProposto3 {
    public class ExercicioP3 {
        public void ExP3() {
            Console.WriteLine("Digite o valor das variáveis A, B, C e D para efetuar a diferença do produto de A e B por C e D: ");

            Console.WriteLine("Valor A:");
            int valorA = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor B:");
            int valorB = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor C:");
            int valorC = int.Parse(Console.ReadLine());

            Console.WriteLine("Valor D:");
            int valorD = int.Parse(Console.ReadLine());

            int resultado = valorA*valorB - valorC*valorD;

            Console.WriteLine("Diferenca = "+resultado);
        }
    }
}