using System;
using System.Globalization;

namespace ExercicioProposto {
    public class ExercicioP7 {
        public void ExP7() {
            RetanguloExP7 dadosRetangulo = new RetanguloExP7();

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
