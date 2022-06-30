using System;
using System.Globalization;

namespace ExercicioProposto4 {
    public class ExercicioP4 {
        public void ExP4() {
            Console.WriteLine("Digite o numero do funcionário: ");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas do funcionário: ");
            double horasTrabalhadas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que o funcionário recebe por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioFuncionario = valorHora * horasTrabalhadas;

            Console.WriteLine("Number = "+numeroFuncionario);
            Console.WriteLine("Salary = U$" +salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}