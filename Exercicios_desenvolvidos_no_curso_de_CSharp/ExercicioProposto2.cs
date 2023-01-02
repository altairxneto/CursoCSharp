using System;
using System.Globalization;

namespace ExercicioProposto {
    public class ExercicioP2 {
        public void ExP2() {
            Console.WriteLine("Digite o valor do raio do circulo: ");
            double raioCirculo = double.Parse(Console.ReadLine());

            double resultado = 3.14159 * Math.Pow(raioCirculo, 2);

            Console.WriteLine("A = "+resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}