using System;
using System.Globalization;

namespace ExercicioProposto {
    public class ExercicioP5 {
        public static void Main() {
            Console.WriteLine("Detalhes peça 1. Digite o código da peça, o número de peças e o valor de cada peça:");
            string peca1 = Console.ReadLine();

            Console.WriteLine("Detalhes peça 2. Digite o código da peça, o número de peças e o valor de cada peça:");
            string peca2 = Console.ReadLine();

            string[] peca1Split = peca1.Split(' ');
            string[] peca2Split = peca2.Split(' ');

            int codigoPeca1 = int.Parse(peca1Split[0]);
            int numeroPeca1 = int.Parse(peca1Split[1]);
            double valorPeca1 = double.Parse(peca1Split[2],CultureInfo.InvariantCulture);

            int codigoPeca2 = int.Parse(peca2Split[0]);
            int numeroPeca2 = int.Parse(peca2Split[1]);
            double valorPeca2 = double.Parse(peca2Split[2], CultureInfo.InvariantCulture);

            double valorPagar = valorPeca1*numeroPeca1 + valorPeca2*numeroPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ "+valorPagar.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}