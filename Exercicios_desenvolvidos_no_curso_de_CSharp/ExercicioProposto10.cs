using System;
using System.Globalization;

namespace ExercicioProposto {
    public class ExercicioP10 {
        public void ExP10() {
            Console.WriteLine("Digite a cotação do dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade de dolares que irá comprar: ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O valor a ser pago em reais é: "+ConversorDeMoedaExP10.ConversorDeMoeda(cotacaoDolar, quantidadeDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
