using System;

namespace ExercicioFixacao {
    public class ExercicioF3 {
        public static void Main() {
            Funcionario dadosFuncionario = new Funcionario();

            Console.WriteLine("Digite seu nome: ");
            dadosFuncionario.Nome = Console.ReadLine();

            Console.WriteLine("Digite seu salario bruto: ");
            dadosFuncionario.SalarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite os impostos: ");
            dadosFuncionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine(dadosFuncionario);

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagemAumentarSalario = double.Parse(Console.ReadLine());
            dadosFuncionario.AumentarSalario(porcentagemAumentarSalario);

            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(dadosFuncionario);

        }
    }
}
