using System;
using System.Collections.Generic;
using System.Globalization;

namespace Projetos {
    public class ProjetoDeListaFuncionario {
        public static void Main(string[] args) {
            Console.WriteLine("Digite o número de funcionários: ");
            int quantidadeFuncionario = int.Parse(Console.ReadLine());

            Funcionario pessoa;
            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            for(int contador = 0; contador < quantidadeFuncionario; contador++) {
                Console.WriteLine("Funcionário#"+(contador+1));

                Console.WriteLine("Digite o ID do funcionário:");
                int idFuncionario = int.Parse(Console.ReadLine());
                int numeroWhile = 0;
                foreach(Funcionario funcionarios in listaDeFuncionarios) {
                    while (numeroWhile < 1) {
                        if (funcionarios.Id == idFuncionario) {
                            Console.WriteLine("Este ID já está em uso, digite outro ID: ");
                            idFuncionario = int.Parse(Console.ReadLine());
                        }
                        else {
                            numeroWhile++;
                        }
                    }

                }

                Console.WriteLine("Digite o nome do funcionario:");
                string nomeFuncionario = Console.ReadLine();

                Console.WriteLine("Digite o salário do funcionário:");
                double salarioFuncionario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                pessoa = new Funcionario(idFuncionario, nomeFuncionario, salarioFuncionario);

                listaDeFuncionarios.Insert(contador, pessoa);
            }

            Console.WriteLine("Digite o ID do funcionário para aumentar o salário:");
            int idAumentarSalario = int.Parse(Console.ReadLine());

            Funcionario procurarId = listaDeFuncionarios.Find(x => x.Id == idAumentarSalario);
            if(procurarId != null) {
                Console.WriteLine("Digite a porcentagem de aumento do salário:");
                double porcentagemAumentarSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                procurarId.AumentarSalario(porcentagemAumentarSalario);
            }
            else {
                Console.WriteLine("ID não encontrado.");
            }

            foreach(Funcionario funcionarios in listaDeFuncionarios) {
                Console.WriteLine(funcionarios);
            }
        }
    }
}