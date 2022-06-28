using PrimeiroExercicio;
using System;
using System.Globalization;

namespace PrimeiroExercicio {
    public class Exercicio1 {
        public void Ex1() {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2} \n");
            Console.WriteLine($"Registro: {idade} de idade, código {codigo} e genero: {genero} \n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8} ");
            Console.WriteLine($"Arredondado(tres casas decimais): {medida:F3}");
            Console.WriteLine("Separados decimal invariant Culture: "+medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
