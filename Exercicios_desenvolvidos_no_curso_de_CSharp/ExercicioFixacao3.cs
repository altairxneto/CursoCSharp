using System;

namespace ExercicioFixacao {
    public class ExercicioF3 {
        public void ExF3() {
            PessoaExF3 primeiraPessoa = new PessoaExF3();
            PessoaExF3 segundaPessoa = new PessoaExF3();

            Console.WriteLine("Digite o nome da primeira pessoa e a idade respectivamente:");
            string informacoesPessoaUm = Console.ReadLine();

            string[] separarInformacoesUm = informacoesPessoaUm.Split(' ');

            primeiraPessoa.nome = separarInformacoesUm[0];
            primeiraPessoa.idade = int.Parse(separarInformacoesUm[1]);

            Console.WriteLine("Digite o nome da segunda pessoa e a idade respectivamente:");
            string informacoesPessoaDois = Console.ReadLine();

            string[] separarInformacoesDois = informacoesPessoaDois.Split(' ');

            segundaPessoa.nome = separarInformacoesDois[0];
            segundaPessoa.idade = int.Parse(separarInformacoesDois[1]);

            Console.WriteLine("Primeira pessoa:");
            Console.WriteLine("Nome: "+primeiraPessoa.nome+" Idade: "+primeiraPessoa.idade);

            Console.WriteLine();

            Console.WriteLine("Segunda pessoa:");
            Console.WriteLine("Nome: " + segundaPessoa.nome + " Idade: " + segundaPessoa.idade);

            if (primeiraPessoa.idade > segundaPessoa.idade) {
                Console.WriteLine("Pessoa mais velha: Primeira");
            }
            else {
                Console.WriteLine("Pessoa mais velha: Segunda");
            }
        }
    }
}
