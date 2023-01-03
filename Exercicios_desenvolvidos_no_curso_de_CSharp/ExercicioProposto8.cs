using System;

namespace ExercicioProposto {
    public class ExercicioP8 {
        public void ExP8() {
            FuncionarioExP8 dadosFuncionario = new FuncionarioExP8();

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
