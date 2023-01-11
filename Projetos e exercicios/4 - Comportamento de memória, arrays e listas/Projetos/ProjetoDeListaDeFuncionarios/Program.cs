using System;
using System.Collections.Generic;

namespace Projetos {
    public class ProjetoDeListaFuncionario {
        public static void Main(string[] args) {
            Console.WriteLine("Digite o número de funcionários: ");
            int quantidadeFuncionario = int.Parse(Console.ReadLine());

            Funcionario pessoa = new Funcionario();
            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            for(int contador = 0; contador < quantidadeFuncionario; contador++) {
                Console.WriteLine("Digite o ID do funcionário: ");
                listaDeFuncionarios.Insert(contador, pessoa);
            }
        }
    }
}