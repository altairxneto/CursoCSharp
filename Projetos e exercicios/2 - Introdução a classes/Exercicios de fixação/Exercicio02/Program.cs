using System;
using System.Globalization;

namespace ExercicioFixacao {
    public class ExercicioF2 {
        public static void Main() {
            Retangulo dadosRetangulo = new Retangulo();

            Console.WriteLine("Digite o valor da altura do retangulo: ");
            dadosRetangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor da largura do retangulo: ");
            dadosRetangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + dadosRetangulo.AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO: " + dadosRetangulo.PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + dadosRetangulo.DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
