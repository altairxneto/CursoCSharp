using System;

namespace ExercicioFixacao {
    public class ExercicioF1 {
        public static void Main() {
            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa e a idade respectivamente:");
            string informacoesPessoaUm = Console.ReadLine();

            string[] separarInformacoesUm = informacoesPessoaUm.Split(' ');

            primeiraPessoa.Nome = separarInformacoesUm[0];
            primeiraPessoa.Idade = int.Parse(separarInformacoesUm[1]);

            Console.WriteLine("Digite o nome da segunda pessoa e a idade respectivamente:");
            string informacoesPessoaDois = Console.ReadLine();

            string[] separarInformacoesDois = informacoesPessoaDois.Split(' ');

            segundaPessoa.Nome = separarInformacoesDois[0];
            segundaPessoa.Idade = int.Parse(separarInformacoesDois[1]);

            Console.WriteLine("Primeira pessoa:");
            Console.WriteLine("Nome: "+primeiraPessoa.Nome+" Idade: "+primeiraPessoa.Idade);

            Console.WriteLine();

            Console.WriteLine("Segunda pessoa:");
            Console.WriteLine("Nome: " + segundaPessoa.Nome + " Idade: " + segundaPessoa.Idade);

            if (primeiraPessoa.Idade > segundaPessoa.Idade) {
                Console.WriteLine("Pessoa mais velha: Primeira");
            }
            else {
                Console.WriteLine("Pessoa mais velha: Segunda");
            }
        }
    }
}
