using System;
using System.Globalization;

namespace ExercicioProposto6 {
    public class ExercicioP6 {
        public void ExP6() {
            Console.WriteLine("Digite os valores de A, B e C respectivamente em uma única linha:");
            string valores = Console.ReadLine();

            string[] valoresSeparados = valores.Split(' ');

            double valorA = double.Parse(valoresSeparados[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(valoresSeparados[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(valoresSeparados[2], CultureInfo.InvariantCulture);

            double areaTriangulo = valorA * valorC / 2;
            double areaCirculo = 3.14159 * Math.Pow(valorC, 2);
            double areaTrapezio = (valorA + valorB) * valorC / 2;
            double areaQuadrado = valorB * valorB;
            double areaRetangulo = valorA * valorB;

            Console.WriteLine("Triangulo: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Circulo: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapezio: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retangulo: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}