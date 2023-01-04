using System;
using System.Globalization;

namespace ExercicioProposto {
    public class ExercicioP9 {
        public void ExP9() {
            AlunoExP9 dadosAluno = new AlunoExP9();

            Console.WriteLine("Digite o nome do aluno: ");
            dadosAluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas (em uma escala de 0 a 100), N1 N2 e N3 respectivamente:");
            string notasAluno = Console.ReadLine();

            string[] notasSeparadas = notasAluno.Split(' ');
            dadosAluno.NotaUm = double.Parse(notasSeparadas[0]);
            dadosAluno.NotaDois = double.Parse(notasSeparadas[1]);
            dadosAluno.NotaTres = double.Parse(notasSeparadas[2]);

            Console.WriteLine(dadosAluno);

        }
    }
}
