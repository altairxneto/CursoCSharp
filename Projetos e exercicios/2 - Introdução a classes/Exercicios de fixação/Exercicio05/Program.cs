using System;
using System.Globalization;

namespace ExercicioFixacao {
    public class ExercicioF5 {
        public static void Main() {
            Console.WriteLine("Digite a cotação do dolar: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a quantidade de dolares que irá comprar: ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O valor a ser pago em reais é: "+ConversorDeMoeda.Conversor(cotacaoDolar, quantidadeDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
