using Projeto.Entities;
using System;

namespace Projeto {
    public class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Digite a quantidade de estudantes para o Curso A: ");
            int quantidadeDeEstudantesA = int.Parse(Console.ReadLine());

            HashSet<int> cursoA = new();
            HashSet<int> cursoB = new();
            HashSet<int> cursoC = new();

            for (int contador = 0; contador < quantidadeDeEstudantesA; contador++) {
                Console.WriteLine("Digite o codigo do aluno do aluno " + (contador+1) + ":");
                int codigo = int.Parse(Console.ReadLine());

                cursoA.Add(codigo);
            }

            Console.WriteLine("Digite a quantidade de estudantes para o Curso B: ");
            int quantidadeDeEstudantesB = int.Parse(Console.ReadLine());

            for (int contador = 0; contador < quantidadeDeEstudantesB; contador++) {
                Console.WriteLine("Digite o codigo do aluno do aluno " + (contador + 1) + ":");
                int codigo = int.Parse(Console.ReadLine());

                cursoB.Add(codigo);
            }

            Console.WriteLine("Digite a quantidade de estudantes para o Curso C: ");
            int quantidadeDeEstudantesC = int.Parse(Console.ReadLine());

            for (int contador = 0; contador < quantidadeDeEstudantesC; contador++) {
                Console.WriteLine("Digite o codigo do aluno do aluno " + (contador + 1) + ":");
                int codigo = int.Parse(Console.ReadLine());

                cursoC.Add(codigo);
            }

            HashSet<int> totalAlunos = new(cursoA);

            totalAlunos.UnionWith(cursoB);
            totalAlunos.UnionWith(cursoC);

            Console.WriteLine("O total de estudantes é de: " + totalAlunos.Count + " alunos");
        }
    }
}